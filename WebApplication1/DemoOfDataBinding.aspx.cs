using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DemoOfDataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(NorthwindDataSet1 ds=new NorthwindDataSet1())
            {
                using (WebApplication1.NorthwindDataSet1TableAdapters.EmployeesTableAdapter taEmployee
                    = new NorthwindDataSet1TableAdapters.EmployeesTableAdapter())
                {
                    taEmployee.Fill(ds.Employees);
                    this.GridView1.DataSource = ds.Employees;
                    this.GridView1.DataBind();
                }
            }
        }
    }
}