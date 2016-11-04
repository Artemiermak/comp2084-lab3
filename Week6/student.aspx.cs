using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// add 2 refeneces to acces to database
//this allows to our Solution use Entity Framework to use our database
using System.Web.ModelBinding;

namespace Week6
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the  departments and display the grid view
            getStudents();
        }

        protected void getStudents()
        {
            // connect to DB
            var conn = new ContosoEntities();

            // run the query using LINQ
            var Students = from s in conn.Students
                           select s;

            // display query result in a gridveiw
            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();

        }

        protected void grdStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // 1.determine which row in the grid the user clicked
            Int32 gridIndex = e.RowIndex;

            // 2. find the DepartmentID value in the selected row
            Int32 StudentID = Convert.ToInt32(grdStudents.DataKeys[gridIndex].Value);

            // 3. connect to the db
            var conn = new ContosoEntities();


            // 4. delete the selected Department

            Student s = new Student();
            s.StudentID = StudentID;
            conn.Students.Attach(s);



            conn.Students.Remove(s);
            conn.SaveChanges();

            // 5. refresh the gridview --> call reload table content
            getStudents();
        }
    }
}