using BobsPizza.DTO.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                outputLabel.Text = String.Format("{0:C}", calcTotal());
            }
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            DTO.Customer newCustomer = GetNewCustomerInputData();

            try
            {
                Domain.CustomerManager.AddCustomer(newCustomer);
            }
            catch (CustomerInputNameException)
            {
                exceptionLabel.Text = "Enter in proper Name";
                return;
            }
            catch (CustomerAddressException)
            {
                exceptionLabel.Text = "Enter in proper Address.";
                return;
            }
            catch (CustomerZipException)
            {
                exceptionLabel.Text = "Enter in proper Zip code.";
                return;
            }
            catch (CustomerPhoneException)
            {
                exceptionLabel.Text = "Enter in proper Phone number.";
                return;
            }
            catch (Exception)
            {
                exceptionLabel.Text = "Unknown Error";
                return;
            }

            Response.Redirect("SuccessPage.aspx");
        }

        private DTO.Customer GetNewCustomerInputData()
        {
            var newCustomer = new DTO.Customer();

            newCustomer.OrderID = Guid.NewGuid();
            newCustomer.Size = sizeDropDownList.SelectedValue.ToString();
            newCustomer.Crust = crustDropDownList.SelectedValue.ToString();
            newCustomer.Sausage = sausageCheckBox.Checked.ToString();
            newCustomer.Pepperoni = pepperoniCheckBox.Checked.ToString();
            newCustomer.Onions = onionCheckBox.Checked.ToString();
            newCustomer.Green_Peppers = greenPeppersCheckBox.Checked.ToString();
            newCustomer.Total_Cost = outputLabel.Text;
            newCustomer.Name = nameTextBox.Text;
            newCustomer.Address = addressTextBox.Text;
            newCustomer.Zip = zipTextBox.Text;
            newCustomer.Phone = phoneTextBox.Text;
            newCustomer.Payment_Type = paymentOptionsRadioButtonList.SelectedValue.ToString();
            newCustomer.Completed = "Not Completed";

            return newCustomer;
        }

        private double calcTotal()
        {
            DTO.Customer newCustomer = GetNewCustomerInputData();

            return Domain.CustomerManager.calcTotal(newCustomer); ;
        }

        protected void sizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0:C}", calcTotal());
        }

        protected void crustDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0:C}", calcTotal());
        }

        protected void sausageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0:C}", calcTotal());
        }

        protected void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0:C}", calcTotal());
        }

        protected void onionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0:C}", calcTotal());
        }

        protected void greenPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Text = String.Format("{0:C}", calcTotal());
        }
    }
}