using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _13.WebForms.Models; 


namespace _13.WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var userCredentials = new Credentials(txtName.Text, txtPassword.Text, int.Parse(txtAge.Text), txtEmail.Text);

            userCredentials.SaveCredentials(userCredentials);

            this.Controls.Clear();

            
        }

    }
}