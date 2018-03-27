using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string strfirstNumber = value1.Text;
            string strsecondNumber = value2.Text;

            double dvalue1 = Convert.ToDouble(strfirstNumber);
            double dvalue2 = Convert.ToDouble(strsecondNumber);

            double dsum = dvalue1 + dvalue2;

            string strsum = dsum.ToString();

            outputLabel.Text = strsum;

        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            string strfirstNumber = value1.Text;
            string strsecondNumber = value2.Text;

            double dvalue1 = Convert.ToDouble(strfirstNumber);
            double dvalue2 = Convert.ToDouble(strsecondNumber);

            double ddifference = dvalue1 - dvalue2;

            string strdifference = ddifference.ToString();

            outputLabel.Text = strdifference;
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            string strfirstNumber = value1.Text;
            string strsecondNumber = value2.Text;

            double dvalue1 = Convert.ToDouble(strfirstNumber);
            double dvalue2 = Convert.ToDouble(strsecondNumber);

            double dproduct = dvalue1 * dvalue2;

            string strproduct = dproduct.ToString();

            outputLabel.Text = strproduct;
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            string strfirstNumber = value1.Text;
            string strsecondNumber = value2.Text;

            double dvalue1 = Convert.ToDouble(strfirstNumber);
            double dvalue2 = Convert.ToDouble(strsecondNumber);

            double dquotient = dvalue1 / dvalue2;

            string strqoutient = dquotient.ToString();

            outputLabel.Text = strqoutient;
        }
    }
}