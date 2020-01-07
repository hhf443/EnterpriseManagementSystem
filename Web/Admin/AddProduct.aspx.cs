using com.website.BLL;
using com.website.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class AddProduct : System.Web.UI.Page
    {
        static string uploadFolder = "upload/";

        protected void Page_Load(object sender, EventArgs e)
        {
            divResult.InnerHtml = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //如果没有上传文件，或上传的文件不是jpg格式的，提示并返回
            if (!fuPicture.HasFile || !this.CheckFileExtendsName(fuPicture.FileName))
            {
                divResult.InnerHtml = "<script>alert('请上传JPG格式的图片！');</script>";
                return;
            }
            //获取页面上的数据
            ProductInfo product = this.PackagingProductForPage();
            //保存文件到指定位置
            fuPicture.SaveAs(Server.MapPath("~/" + product.Picture));
            //将产品信息保存到数据库
            ProductManager.AppendProduct(product);
            divResult.InnerHtml = "<script>alert('上传成功。单击确定返回产品管理列表。');location='ProductList.aspx';</script>";
        }

        /// <summary>
        /// 验证文件扩展名
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool CheckFileExtendsName(string filename)
        {
            //用正则表达式验证文件名的扩展名是不是jpg或者jpeg
            Regex picExtendsName = new Regex("(.jpg|.jpeg)$");
            return picExtendsName.IsMatch(filename.ToLower());
        }

        /// <summary>
        /// 封装页面上的产品信息
        /// </summary>
        /// <returns></returns>
        private ProductInfo PackagingProductForPage()
        {
            ProductInfo product = new ProductInfo();
            product.Details = this.txtDetails.Text;
            product.Name = this.txtName.Text;
            try { product.Price = int.Parse(this.txtPrice.Text); }
            catch { }
            //创建一个图片路径，规则是上传文件夹地址+当前年份+当前月份+当前日+（1000000－9999999）的一个数字+“.jpg”
            product.Picture = uploadFolder +
                DateTime.Now.Year + DateTime.Now.Month +
                DateTime.Now.Day + new Random().Next(1000000, 9999999) + ".jpg";
            return product;
        }
    }
}