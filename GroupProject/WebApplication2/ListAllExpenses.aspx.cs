using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ListAllExpenses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ProductsToDisplay = FileOperation.ReadProductsFromDataBase();

            this.ProductsRepeater.DataSource = ProductsToDisplay;
            this.ProductsRepeater.DataBind();
        }
    }
}