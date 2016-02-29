using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentApi
{
    public partial class SortStudentInOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            
            
            
        }

        protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOrder.SelectedValue == "Accending")
            {
                var list = FileOperations.ReadStudentsFromDatabase().OrderBy(n => n.AverageAssessment);

                myDataGrid.DataSource = list;
                myDataGrid.DataBind();

            }
            else if (ddlOrder.SelectedValue == "Descending")
            {
                var list = FileOperations.ReadStudentsFromDatabase().OrderByDescending(n => n.AverageAssessment);

                myDataGrid.DataSource = list;
                myDataGrid.DataBind();
            }
        }
    }
}