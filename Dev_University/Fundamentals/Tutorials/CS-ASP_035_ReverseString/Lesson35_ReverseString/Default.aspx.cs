using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson35_ReverseString
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "Kevin Gaughan";
            string reverse = "";

            for (int i = 0; i < name.Length; i++)
            {
                reverse += name[name.Length - 1 - i].ToString();
            }

            outputLabel.Text = reverse;
        }
    }
}