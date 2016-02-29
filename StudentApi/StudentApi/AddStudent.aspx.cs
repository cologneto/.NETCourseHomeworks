using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentApi.Models;


namespace StudentApi
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void toggleActiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student(this.txtName.Text, this.toggleActiveBox.SelectedValue, int.Parse(this.txtFacultyNumber.Text), double.Parse(this.txtAssessment.Text));

            if (FileOperations.AddStudentToStudentDatabase(student))
            {
                lblMessage.Text = "Student successfuly added to database";
                System.Threading.Thread.Sleep(5000);
            }
            else
            {
                lblMessage.Text = "You fucking idiot?!?";
            }
            

            //Response.Redirect(Request.RawUrl);
        }
    }
}