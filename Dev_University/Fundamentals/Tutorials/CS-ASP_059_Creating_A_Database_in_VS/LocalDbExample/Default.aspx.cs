using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalDbExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            testEntities db = new testEntities();

            var customers = db.Customers;

            string result = "";

            /*
            foreach (var customer in customers)
            {
                result += "<p>" + customer.Name + "</p>";
            }
            */

            customersGridView.DataSource = customers.ToList();
            // customersGridView.DataBind();

            outputLabel.Text = result;
        }

        protected void customersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}