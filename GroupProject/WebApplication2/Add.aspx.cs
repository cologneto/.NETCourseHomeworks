using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void importbutton_Click(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Parse(this.DateTxtBox.Text);
            //string name=productxt.Text;
            //double pr=double.Parse(pricetxtbox.Text);
            var productToAdd = new Product(
              DateTime.Parse(this.DateTxtBox.Text),
              this.productxt.Text,
              double.Parse(this.pricetxtbox.Text));

            if (FileOperation.AddProductToDataBase(productToAdd))
            {
                this.msglabel.Text = "Successfully added item";
                this.DateTxtBox.Text = string.Empty;
                this.productxt.Text = string.Empty;
                this.pricetxtbox.Text = string.Empty;
            }
            else
            {
                this.msglabel.ForeColor = System.Drawing.Color.Red;
                this.msglabel.Text = "An error occured while adding the product";
            }
        }
    }
}