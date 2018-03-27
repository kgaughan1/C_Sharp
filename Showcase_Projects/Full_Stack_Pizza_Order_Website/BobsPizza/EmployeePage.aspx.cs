using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobsPizza
{
    public partial class EmployeePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var customers = Domain.CustomerManager.GetCustomers();

            var activeOrders = new List<DTO.Customer>();

            foreach (var customer in customers)
            {
                if (customer.Completed == "Not Completed")
                {
                    activeOrders.Add(customer);
                }
            }

            customersGridView.DataSource = activeOrders.ToList();
            customersGridView.DataBind();
        }

        
        protected void customersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            try
            {
                GridViewRow row = customersGridView.Rows[index];
                var value = row.Cells[1].Text.ToString();
                var orderID = Guid.Parse(value);

                Domain.CustomerManager.CompleteOrder(orderID);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                // Log Error
            }
        }
        
    }
}