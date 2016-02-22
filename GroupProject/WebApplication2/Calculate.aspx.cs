using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Calculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toggleActivebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(toggleActivebox.SelectedValue) != 0)
            {

                var list = FileOperation.ReadProductsFromDataBase();
                double SummofAll = 0;
                DateTime dt = DateTime.Now.AddDays(-int.Parse(toggleActivebox.SelectedValue));
                foreach (var item in list)
                {
                    if (item.Date >= dt && item.Date <= DateTime.Now)
                    {
                        SummofAll += item.Price;
                    }
                }
                this.Sum.Text = SummofAll.ToString();
            }
            else
            {
                this.Sum.Text = "";
            }
        }
    }
}