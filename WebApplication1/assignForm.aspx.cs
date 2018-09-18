using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class assignForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (assigndataDataContext db=new assigndataDataContext())
            {
                var query = from emp in db.Employees
                            select new
                            {
                                emp.EmployeeID,
                                emp.LastName,
                                emp.FirstName
                            };
                this.GridView1.DataSource = query;
                this.GridView1.DataBind();
            }
        }
    }
}