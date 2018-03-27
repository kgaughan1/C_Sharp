using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime myValue = DateTime.Now;
            // resultLabel.Text = myValue.ToString();
            resultLabel2.Text = myValue.ToLongDateString();
            resultLabel3.Text = myValue.ToLongTimeString();
            resultLabel.Text = myValue.AddDays(5).ToLongDateString();
        }
    }
}