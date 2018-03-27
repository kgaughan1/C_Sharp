using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {

            /*if (firstTextBox.Text == secondTextBox.Text )
            {
                resultLabel.Text = "Yes, they are equal!";
            }
            else
            {
                resultLabel.Text = "No, they are not equal!";
            }
            */

            /*
            if (coolCheckBox.Checked)
            {
                resultLabel.Text = "Yes, you are cool";
            }
            else
            {
                resultLabel.Text = "Nope, you are not.";
            }
            */

            if ( pizzarb.Checked)
            {
                resultLabel.Text = "You must be from Chicago!";
            }
            else if (saladrb.Checked)
            {
                resultLabel.Text = "You must be healthy!";
            }
            else if (pbajrb.Checked)
            {
                resultLabel.Text = "You must be a fun loving person!";
            }
            else
            {
                resultLabel.Text = "Please select one of the options!";
            }
        }

        protected void coolCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}