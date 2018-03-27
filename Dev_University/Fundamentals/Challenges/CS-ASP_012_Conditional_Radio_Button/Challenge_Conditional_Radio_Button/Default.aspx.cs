using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Conditional_Radio_Button
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                outputImage.ImageUrl = "~/Assets/pencil.png";
                outputLabel.Text = "";
            }
            else if (penRadioButton.Checked)
            {
                outputImage.ImageUrl = "~/Assets/pen.png";
                outputLabel.Text = "";
            }
            else if (phoneRadioButton.Checked)
            {
                outputImage.ImageUrl = "~/Assets/phone.png";
                outputLabel.Text = "";
            }
            else if (tabletRadioButton.Checked)
            {
                outputImage.ImageUrl = "~/Assets/tablet.png";
                outputLabel.Text = "";
            }
            else
            {
                outputLabel.Text = "Please select an option.";
            }
        }
    }
}