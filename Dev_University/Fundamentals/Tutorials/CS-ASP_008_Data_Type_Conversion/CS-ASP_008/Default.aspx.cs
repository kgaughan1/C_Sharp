using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*int i;
            i = "Hello World";
            */

            /*
            int i;
            i = "3";
            */

            /*
            //This will implicitly work because upcasting!!!
            int i = 2000000000;
            long j = i;


            //This will not work because casting from a larger datatype to a smaller datatype.
            //Must explicitly cast!!!
            long k = 2000000000;
            int l = (int)k; // Explicit casting!!! Aware that data loss may occur.

            */


            //double k = 2.5;
            //int j = (int)k;

            // resultLabel.Text = j;

            // resultLabel.Text = (String)j;

            // resultLabel.Text = j.ToString();

            string i = TextBox1.Text;
            int j = int.Parse(i);
            int k = j + 1;

            resultLabel.Text = k.ToString();






        }
    }
}