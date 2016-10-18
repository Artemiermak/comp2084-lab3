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
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the  departments and display the grid view
            getDepartments();
        }
        protected void getDepartments()
        {
            // connect to DB
            var conn = new ContosoEntities();

            // run the query using LINQ
            var Departments = from d in conn.Departments
                              select d;

            // display query result in a gridveiw
            grdDepartments.DataSource = Departments.ToList();
            grdDepartments.DataBind();

        }
    }
}