using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryStatistics
{
    public partial class SearchCountries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";

            var coutriesList = FileOperations.ReadCountrysFromDatabase();

            var CountriesContainingKeyWord = new List<Country>();

            foreach (var book in coutriesList.Where(b =>
                                b.CountryName.ToLower().Contains(this.txtSearchByCountryName.Text.ToLower())))
                                
            {
                CountriesContainingKeyWord.Add(book);
            }

            if (CountriesContainingKeyWord.Count == 0)
            {
                this.messageLabel.Text = "No results found";
            }
            this.myDataGrid.DataSource = CountriesContainingKeyWord;
            this.myDataGrid.DataBind();
        }

       


    }
}