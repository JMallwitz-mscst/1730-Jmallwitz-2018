using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmallwitz2e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox18.Text = "";
            textBox24.Text = "";
            textBox30.Text = "";
            textBox29.Text = "";
            textBox34.Text = "";

            // #01
            decimal subtotal = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = (LogicalOperations.Q01(subtotal)).ToString();

            // #02
            int timeInservice = Convert.ToInt32(textBox4.Text);
            textBox3.Text = (LogicalOperations.Q02(timeInservice)).ToString();

            // #03
            bool isValid = Convert.ToBoolean(textBox6.Text);
            int years = Convert.ToInt32(textBox9.Text);
            int counter = Convert.ToInt32(textBox8.Text);
            textBox5.Text = LogicalOperations.Q03(isValid, years, counter).ToString();
            textBox7.Text = counter.ToString();

            // #04
            counter = Convert.ToInt32(textBox8.Text);
            textBox11.Text = LogicalOperations.Q04(isValid, years, counter).ToString();
            textBox10.Text = counter.ToString();
            
            // #05
            counter = Convert.ToInt32(textBox8.Text);
            textBox13.Text = LogicalOperations.Q05(isValid, years, counter).ToString();
            textBox12.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(textBox8.Text);
            textBox15.Text = LogicalOperations.Q06(isValid, years, counter).ToString();
            textBox14.Text = counter.ToString();

            // #07
            DateTime startDate = Convert.ToDateTime(textBox19.Text);
            DateTime expirationDate = Convert.ToDateTime(textBox17.Text);
            DateTime date = Convert.ToDateTime(textBox16.Text); 
            isValid = Convert.ToBoolean(textBox20.Text);
            textBox18.Text =
                LogicalOperations.Q07(isValid, startDate, expirationDate, date).ToString();

            // #08
            decimal thisYTD = Convert.ToDecimal(textBox25.Text);
            decimal lastYTD = Convert.ToDecimal(textBox23.Text);
            string empType = textBox22.Text;
            int startYear = Convert.ToInt32(textBox21.Text);
            int currentYear = Convert.ToInt32(textBox26.Text);
            textBox24.Text = LogicalOperations.Q08(thisYTD, lastYTD, empType, startYear, currentYear)
                .ToString();

            // #09
            counter = Convert.ToInt32(textBox31.Text);
            years = Convert.ToInt32(textBox28.Text);
            textBox30.Text = LogicalOperations.Q09(years, counter).ToString();
            textBox29.Text = counter.ToString();

            // #10
            int a = Convert.ToInt32(textBox35.Text);
            int b = Convert.ToInt32(textBox33.Text);
            int c = Convert.ToInt32(textBox32.Text);
            int d = Convert.ToInt32(textBox27.Text);
            textBox34.Text = LogicalOperations.Q10(a, b, c, d).ToString();
            // bool v = a > b;
            // bool w = b < c;
            // bool x = c < d;
            // bool y = v && w;
            // bool z = y || x;
            // textBox34.Text = z.ToString();

            // #11
            bool member = Convert.ToBoolean(textBox39.Text);
            decimal price = Convert.ToDecimal(textBox37.Text);
            float weight = Convert.ToSingle(textBox36.Text);
            textBox38.Text = (LogicalOperations.Q11(member, price, weight)).ToString();

            // #12
            member = Convert.ToBoolean(textBox43.Text);
            price = Convert.ToDecimal(textBox41.Text);
            weight = Convert.ToSingle(textBox40.Text);
            textBox42.Text = (LogicalOperations.Q12(member, price, weight)).ToString();

            // #13
            string shipState = textBox46.Text;
            string itemType = textBox44.Text;
            textBox45.Text = (LogicalOperations.Q13(shipState, itemType)).ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
