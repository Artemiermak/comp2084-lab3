using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//  add referenc the model binding library
using System.Web.ModelBinding;
namespace Week6
{
    public partial class department_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new ContosoEntities();
            // use the Department class to create new Deparment object
            Department d = new Department();

            // fill the properties of the new department object
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);

            // save new object to DB
            conn.Departments.Add(d);
            conn.SaveChanges();

            // redirect to the department page
            Response.Redirect("departments.aspx");

        }
    }
}