using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _16_ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime date1 = Calendar1.SelectedDate;
            DateTime date2 = Calendar2.SelectedDate;

            TimeSpan timeSpanDifference = TimeSpan.Parse("0.0:0:00.0");

            if (date1 > date2 )
            {
                timeSpanDifference = date1.Subtract(date2);
            }
            else if (date2 > date1)
            {
                timeSpanDifference = date2.Subtract(date1);
            }
            else
            {
                timeSpanDifference = TimeSpan.Parse("0.0:0:00.0");
            }

            outputLabel.Text = timeSpanDifference.TotalDays.ToString();

            // SEE THE SUGGESTED ANSWER! 
        }
    }
}