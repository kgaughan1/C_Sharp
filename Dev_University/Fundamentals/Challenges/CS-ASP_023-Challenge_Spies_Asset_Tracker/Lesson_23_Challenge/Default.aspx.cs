using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson_23_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetNames = new string[0];
                ViewState.Add("Asset Names", assetNames);

                double[] elections = new double[0];
                ViewState.Add("Elections", elections);

                double[] acts = new double[0];
                ViewState.Add("Acts", acts);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] assetNames = (string[])ViewState["Asset Names"];
            Array.Resize(ref assetNames, assetNames.Length + 1);
            int previousNameIndex = assetNames.GetUpperBound(0);
            assetNames[previousNameIndex] = TextBox1.Text;
            ViewState["Asset Names"] = assetNames;

            double[] elections = (double[])ViewState["Elections"];
            Array.Resize(ref elections, elections.Length + 1);
            int newestElectionNumber = elections.GetUpperBound(0);
            elections[newestElectionNumber] = double.Parse(TextBox2.Text);
            ViewState["Elections"] = elections;

            double[] acts = (double[])ViewState["Acts"];
            Array.Resize(ref acts, acts.Length + 1);
            int newestActsNumber = acts.GetUpperBound(0);
            acts[newestActsNumber] = double.Parse(TextBox3.Text);
            ViewState["Acts"] = acts;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1}<br />(Last Asset you Added: {2}",
            elections.Sum(),
            acts.Average(),
            assetNames[previousNameIndex]
            );

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}