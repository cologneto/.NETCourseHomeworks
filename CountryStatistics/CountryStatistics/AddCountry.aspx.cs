using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryStatistics
{
    public partial class AddCountry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var country = new Country(this.txtCountry.Text, this.txtCapital.Text, int.Parse(this.txtPopulation.Text));

            var listOfCountries = FileOperations.ReadCountrysFromDatabase();

            

            if (FileOperations.AddCountryToCountryDatabase(country))
            {
                lblMessage.Text = "Country successfuly added.";
                this.txtCountry.Text = "";
                this.txtCapital.Text = "";
                this.txtPopulation.Text = "";
            }
            else
            {
                lblMessage.Text = "Country already ecsists";
                this.txtCountry.Text = "";
                this.txtCapital.Text = "";
                this.txtPopulation.Text = "";
            }
        }
    }
}