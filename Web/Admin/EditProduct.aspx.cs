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
    public partial class EditProduct : System.Web.UI.Page
    {
        static string uploadFolder = "upload/";
        protected void Page_Load(object sender, EventArgs e)
        {
            divResult.InnerHtml = "";
            if (!IsPostBack)
            {
                this.BindProduct();
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            //封装产品对象
            ProductInfo product = this.PackagingProductForPage();
            //如果上传控件存在文件
            if (fuPicture.HasFile)
            {
                //检查文件扩展名
                if (!this.CheckFileExtendsName(fuPicture.FileName))
                {
                    divResult.InnerHtml = "<script>alert('请上传JPG格式的图片！');</script>";
                    return;
                }
                //保存新文件至硬盘
                fuPicture.SaveAs(Server.MapPath("~/" + product.Picture));
                //更新产品信息
                ProductManager.ModifyProduct(product);
            }
            else
            {
                //更新除图片之外的产品信息
                ProductManager.ModifyProductNoPicture(product);
            }
            divResult.InnerHtml = "<script>alert('修改成功。单击确定返回产品管理列表。');location='ProductList.aspx';</script>";
        }

        /// <summary>
        /// 绑定产品
        /// </summary>
        private void BindProduct()
        {
            try
            {
                int id = int.Parse(Request["id"]);
                ProductInfo product = ProductManager.GetProductById(id);
                this.txtDetails.Text = product.Details;
                this.txtName.Text = product.Name;
                this.txtPrice.Text = product.Price.ToString();
            }
            catch { }
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
            //产品ID就是请求过来时传递的参数id
            try { product.ID = int.Parse(Request["id"]); }
            catch { }
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