using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using com.website.Model;

namespace com.website.DAL
{
    public class ProductService
    {
        public IList<ProductInfo> GetProducts()
        {
            string sql = "select * from tbl_product order by id desc";
            return this.GetProductsBySql(sql);
        }

        public IList<ProductInfo> GetProducts(int startNumber, int length)
        {
            string sql = "select top " + length + " * from tbl_product where id not in (select top "
                + startNumber + " id from tbl_product order by id desc) order by id desc";
            return this.GetProductsBySql(sql);
        }

        public ProductInfo GetById(int id)
        {
            string sql = "select * from tbl_product where id = " + id;
            IList<ProductInfo> productList = this.GetProductsBySql(sql);
            if (productList.Count > 0)
            {
                return productList[0];
            }
            else
            {
                return null;
            }
        }

        public void Append(ProductInfo product)
        {
            string sql = "insert into tbl_product values(@Name, @Picture, @Price, @Details)";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@Name", product.Name);
            prams.Add("@Picture", product.Picture);
            prams.Add("@Price", product.Price);
            prams.Add("@Details", product.Details);

            DBHelper.ExecuteNonQuery(sql, prams);
        }

        public void DeleteById(int id)
        {
            string sql = "delete tbl_product where id = " + id;
            DBHelper.ExecuteNonQuery(sql);
        }

        public void Update(ProductInfo product)
        {
            string sql = "update tbl_product set p_name = @Name, p_picture = @Picture, p_price = @Price, p_details = @Details where id = @ID";
            Dictionary<string, object> prams = new Dictionary<string, object>();
            prams.Add("@Name", product.Name);
            prams.Add("@Picture", product.Picture);
            prams.Add("@Price", product.Price);
            prams.Add("@Details", product.Details);
            prams.Add("@ID", product.ID);

            DBHelper.ExecuteNonQuery(sql, prams);
        }

        /// <summary>
        /// 执行SQL语句，并封装List
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private IList<ProductInfo> GetProductsBySql(string sql)
        {
            IList<ProductInfo> productList = new List<ProductInfo>();
            using (DbDataReader reader = DBHelper.ExecuteReader(sql))
            {
                while (reader.Read())
                {
                    productList.Add(this.GetProductByReader(reader));
                }
            }
            return productList;
        }        

        /// <summary>
        /// 从Reader里取出值并封装对象
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private ProductInfo GetProductByReader(DbDataReader reader)
        {
            ProductInfo newProduct = new ProductInfo();
            newProduct.ID = reader.GetInt32(0);
            newProduct.Name = reader.GetString(1);
            newProduct.Picture = reader.GetString(2);
            newProduct.Price = reader.GetInt32(3);
            newProduct.Details = reader.GetString(4);
            return newProduct;
        }
    }
}


/*

create table tbl_product(
	id int identity(1,1) primary key,
	p_name nvarchar(50) not null,
	p_picture varchar(100) not null,
	p_price int not null,
	p_details text not null
)

 */