using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // resultLabel.Text = "<p style=\"color:#ee3b32;\">Hi</p>";

            string value = valueTextBox.Text;

            // resultLabel.Text = value[2].ToString();

            // StartWith(), EndWith(), Contains()

            if (value.StartsWith("A"))
                resultLabel.Text = "Value start with 'A'";

            if (value.EndsWith("."))
                resultLabel.Text += "String ends with '.'";

            if (value.Contains("good"))
                resultLabel.Text += "Value contains the word 'good'";

            int index = value.IndexOf("good");
            resultLabel.Text = " 'good' begins at index " + index.ToString();

            // Insert, Remove


        }
    }
}