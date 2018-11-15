using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jmallwitz2h1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox1Aresult.Text = DateTime.Now.ToShortDateString();
            TextBox1Bresult.Text = DateTime.Now.ToShortTimeString();
            TextBox2Aresult.Text = DateTime.Today.ToShortDateString();
            TextBox2Bresult.Text = DateTime.Today.ToShortTimeString();
            TextBox3Aresult.Text = DateTime.Today.Year.ToString();
            TextBox3Bresult.Text = DateTime.Today.Month.ToString();
            TextBox3Cresult.Text = DateTime.Today.Day.ToString();
            TextBox4result.Text = DateTime.Today.AddDays(90).ToShortDateString();
            TextBox5result.Text = DateTime.Today.AddMonths(3).ToShortDateString();
            TextBox6result.Text = Ex2hCalculations.DateCalc06(TextBox6A.Text, TextBox6B.Text, TextBox6C.Text);
            TextBox7result.Text = Ex2hCalculations.DateCalc07(TextBox7A.Text);
            TextBox8result.Text = Ex2hCalculations.DateCalc08(TextBox8A.Text);
            TextBox9result.Text = Ex2hCalculations.DateCalc09(TextBox9A.Text, TextBox9B.Text);
            TextBox10result0.Text = Ex2hCalculations.DateCalc10(TextBox10A.Text, TextBox10B.Text);
        }
    }
}