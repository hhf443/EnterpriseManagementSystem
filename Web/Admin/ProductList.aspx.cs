using com.website.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindList();
            }
        }

        protected void lnkbtnDelete_Command(object sender, CommandEventArgs e)
        {
            try
            {
                int id = int.Parse(e.CommandArgument.ToString());
                ProductManager.DeleteById(id);
            }
            catch { }
            this.BindList();
        }

        protected void BindList()
        {
            this.rptProducts.DataSource = ProductManager.GetProductList();
            this.rptProducts.DataBind();
        }
    }
}