using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(35);
            }

            // Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DateTime finishDate = Calendar1.SelectedDate;
            TimeSpan timeOff = Calendar2.SelectedDate.Subtract(finishDate);

            DateTime startDate = Calendar2.SelectedDate;
            TimeSpan workTime = Calendar3.SelectedDate.Subtract(startDate);

            double timeOffDays = timeOff.TotalDays;
            double timeWorkDays = workTime.TotalDays;

            double cost = 0;

            string nameTextBox = TextBox1.Text;
            string assignmentNameTextBox = TextBox2.Text;

            if (timeOffDays < 14)
            {
                outputLabel.Text = "Error: Spy must have at least two weeks off before starting a new job.";
            }
            else if (timeWorkDays > 21)
            {
                cost = timeWorkDays * 500 + 1000;
                outputLabel.Text = String.Format("Assignment of {0} to assignment Project: {1} is authorized.  Bugdet total: {2:C}.", nameTextBox, assignmentNameTextBox, cost);
            }
            else
            {
                cost = timeWorkDays * 500;
                outputLabel.Text = String.Format("Assignment of {0} to assignment Project: {1} is authorized.  Bugdet total: {2:C}.", nameTextBox, assignmentNameTextBox, cost);
            }
        }
    }
}