using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson_34_ChallengePostalCalculation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateCost(0.15);
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateCost(0.25);
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateCost(0.45);
        }

        private void CalculateCost(double ratio)
        {
            int width = stripWidth();
            int height = stripHeight();
            
            if (!(lengthTextBox.Text.Trim().Length == 0))
            {
                int length = stripLength();
                double result = width * height * length * ratio;
                resultLabel.Text = result.ToString();
            }
            else
            {
                double result = width * height * ratio;
                resultLabel.Text = result.ToString();
            }
        }

        private int stripWidth()
        {
            int width = int.Parse(widthTextBox.Text);
            return width;
        }

        private int stripHeight()
        {
            int height = int.Parse(heightTextBox.Text);
            return height;
        }

        private int stripLength()
        {
            int length = int.Parse(lengthTextBox.Text);
            return length;
        }
    }
}