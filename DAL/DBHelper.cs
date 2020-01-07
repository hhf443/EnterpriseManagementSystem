
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace com.website.DAL
{
    /// <summary>
    /// 数据库访问封装类
    /// </summary>
    class DBHelper
    {
        private static readonly string _providerName = ConfigurationManager.ConnectionStrings["CompanySiteDB"].ProviderName;
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["CompanySiteDB"].ConnectionString;

        /// <summary>
        /// 获取数据库链接
        /// </summary>
        /// <returns></returns>
        private static DbConnection GetConnection()
        {
            //创建数据提供者工厂
            DbProviderFactory factory = DbProviderFactories.GetFactory(_providerName);
            //用工厂创建数据库链接
            DbConnection connection = factory.CreateConnection();
            //设置链接字符串
            connection.ConnectionString = _connectionString;
            return connection;
        }

        /// <summary>
        /// 根据命令字符串和数据库链接创建DbCommand对象
        /// </summary>
        /// <param name="commandText">命令字符串（T-SQL语句）</param>
        /// <param name="connection">数据库链接</param>
        /// <returns></returns>
        private static DbCommand GetCommand(string commandText, DbConnection connection)
        {
            //创建命令
            DbCommand command = connection.CreateCommand();
            //设置命令字符串
            command.CommandText = commandText;
            //设置DbCommand对象的类型
            command.CommandType = CommandType.Text;
            return command;
        }

        /// <summary>
        /// 封装数据库参数对象
        /// </summary>
        /// <param name="paramName">参数名字</param>
        /// <param name="paramValue">参数值</param>
        /// <param name="command">DbCommand对象</param>
        /// <returns></returns>
        private static DbParameter GetParameter(string paramName, object paramValue, DbCommand command)
        {
            //创建一个DbCommand对象的参数
            DbParameter parameter = command.CreateParameter();
            //设置参数名称
            parameter.ParameterName = paramName;
            //设置参数值
            parameter.Value = paramValue;
            return parameter;
        }

        /// <summary>
        /// 封装参数列表
        /// </summary>
        /// <param name="parms">参数列表</param>
        /// <param name="command">要执行的SQL语句</param>
        private static void PackingParameters(Dictionary<string, object> parms, DbCommand command)
        {
            if (parms != null)
            {
                //遍历参数字典
                foreach (var p in parms)
                {
                    command.Parameters.Add(GetParameter(p.Key, p.Value, command));
                }
            }
        }

        /// <summary>
        /// 执行带参的SQL语句
        /// </summary>
        /// <param name="sqlCommand">要执行的SQL语句</param>
        /// <param name="parms">参数列表</param>
        public static void ExecuteNonQuery(string sqlCommand, Dictionary<string, object> parms)
        {
            //用using语句监控DbConnection对象，以保证资源释放
            using (DbConnection connection = GetConnection())
            {
                //创建DbCommand对象
                DbCommand command = GetCommand(sqlCommand, connection);
                PackingParameters(parms, command);  //封装参数列表
                connection.Open();  //打开数据库链接
                command.ExecuteNonQuery();  //执行DbCommand命令
                command.Parameters.Clear(); //清理参数
            }
        }
                
        /// <summary>
        /// 执行带参的SQL语句
        /// </summary>
        /// <param name="sqlCommand">要执行的SQL语句</param>
        public static void ExecuteNonQuery(string sqlCommand)
        {
            ExecuteNonQuery(sqlCommand, null);
        }

        /// <summary>
        /// 执行带参的SQL语句，返回一个DataReader
        /// </summary>
        /// <param name="sqlCommand">要执行的SQL语句</param>
        /// <param name="parms">参数列表</param>
        /// <returns>执行结果</returns>
        public static DbDataReader ExecuteReader(string sqlCommand, Dictionary<string, object> parms)
        {
            //创建DbConnection对象，这里不能用using，因为要返回DataReader，而connection一断开，DataReader就无效了。
            DbConnection connection = GetConnection();
            //创建DbCommand对象
            DbCommand command = GetCommand(sqlCommand, connection);
            PackingParameters(parms, command);  //封装参数列表
            connection.Open();//打开数据库链接
            // 调用ExecuteReader时，传递CommandBehavior.CloseConnection参数，这样reader一关闭，连接也同时关闭
            DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            command.Parameters.Clear();//清理参数
            return reader;
        }

        /// <summary>
        /// 执行一个SQL语句，返回一个DataReader
        /// </summary>
        /// <param name="sqlCommand">要执行的SQL语句</param>
        /// <returns>执行结果</returns>
        public static DbDataReader ExecuteReader(string sqlCommand)
        {
            return ExecuteReader(sqlCommand, null);
        }

        /// <summary>
        /// 获取统计结果
        /// </summary>
        /// <param name="sqlCommand">要执行的SQL语句</param>
        /// <param name="parms">参数列表</param>
        /// <returns>执行结果</returns>
        public static int ExecuteScalar(string sqlCommand, Dictionary<string, object> parms)
        {
            int count = 0;
            //用using语句监控DbConnection对象，以保证资源释放
            using (DbConnection conn = GetConnection())
            {
                //创建DbCommand对象
                DbCommand command = GetCommand(sqlCommand, conn);
                PackingParameters(parms, command);  //封装参数列表
                count = (int)command.ExecuteScalar();   //执行命令
            }
            return count;
        }

        /// <summary>
        /// 获取统计结果
        /// </summary>
        /// <param name="sqlCommand">要执行的SQL语句</param>
        /// <returns>执行结果</returns>
        public static int ExecuteScalar(string sqlCommand)
        {
            return ExecuteScalar(sqlCommand,null);
        }

    }
}
