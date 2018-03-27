using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            comparisonTypeLabel.Text = "Equal to";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";

            int first = int.Parse(firstTextBox.Text);
            int second = int.Parse(secondTextBox.Text);

            resultLabel.Text = (first > second) ? "Yes" : "No";

        }
    }
}