using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.ModelBinding;
namespace Week6
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {
                    Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);


                    var conn = new ContosoEntities();

                    var objStud = (from s in conn.Students
                                  where s.StudentID == StudentID
                                  select s).FirstOrDefault();


                    txtFirstMidName.Text = objStud.FirstMidName;
                    txtLastName.Text = objStud.LastName.ToString();
                    txtEnrollmentDate.Text = objStud.EnrollmentDate.ToString("yyyy-MM-dd");
                    
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();

            Student s = new Student();

            // fill the properties of the new student object
            s.LastName = txtLastName.Text;
            s.FirstMidName = txtFirstMidName.Text;
            s.EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);

            // save new object to DB
            conn.Students.Add(s);
            conn.SaveChanges();

            // redirect to the student page
            Response.Redirect("student.aspx");
        }
    }
}