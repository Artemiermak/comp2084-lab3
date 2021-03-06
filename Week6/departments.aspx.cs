﻿using System;
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

        protected void grdDepartments_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // function to delete a Department from the table/grid
            // 1.determine which row in the grid the user clicked
            Int32 gridIndex = e.RowIndex;

            // 2. find the DepartmentID value in the selected row
            Int32 DepartmentID = Convert.ToInt32(grdDepartments.DataKeys[gridIndex].Value);

            // 3. connect to the db
            var conn = new ContosoEntities();


            // 4. delete the selected Department
            /* OPtion 1 =======================================
             * 
             * Department objDep = (from d in conn.Departments
                           where d.DepartmentID == DepartmentID
                           select d).First();
              conn.Departments.Remove(objDep);
              conn.SaveChanges();*/

            Department d = new Department();
            d.DepartmentID = DepartmentID;
            conn.Departments.Attach(d);

            

            conn.Departments.Remove(d);
            conn.SaveChanges();

            // 5. refresh the gridview --> call reload table content
            getDepartments();
        }
    }
}