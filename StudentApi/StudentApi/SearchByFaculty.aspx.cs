using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentApi
{
    public partial class SearchByFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ddlFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFaculty = ddlFaculty.SelectedValue;

            var list = FileOperations.ReadStudentsFromDatabase().Where(x => x.Faculty == selectedFaculty);

            studentsRepeater.DataSource = list;
            studentsRepeater.DataBind();
        }
    }
}