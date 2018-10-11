using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jmallwitz2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passvaluebutton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5Ainput.Text = "2";
            textBox5Binput.Text = "2";
            textBox6input.Text = "Jones";
            textBox7input.Text = "1";
            textBox8Ainput.Text = "1";
            textBox8Binput.Text = "2";
            textBox9input.Text = "500";
            textBox10Ainput.Text = "2";
            textBox10Binput.Text = "3";
        }

        private void failvaluebutton_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.4";
            textBox4input.Text = "true";
            textBox5Ainput.Text = "2";
            textBox5Binput.Text = "3";
            textBox6input.Text = "xyz";
            textBox7input.Text = "0";
            textBox8Ainput.Text = "1";
            textBox8Binput.Text = "1";
            textBox9input.Text = "499";
            textBox10Ainput.Text = "4";
            textBox10Binput.Text = "3";
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            textBox1resultA.Text = "Fail";
            textBox2resultA.Text = "Fail";
            textBox3resultA.Text = "Fail";
            textBox4resultA.Text = "Fail";
            textBox5resultA.Text = "Fail";
            textBox6resultA.Text = "Fail";
            textBox7resultA.Text = "Fail";
            textBox8resultA.Text = "Fail";
            textBox9resultA.Text = "Fail";
            textBox10resultA.Text = "Fail";

            textBox1resultB.Text = "Success";
            textBox2resultB.Text = "Success";
            textBox3resultB.Text = "Success";
            textBox4resultB.Text = "Success";
            textBox5resultB.Text = "Success";
            textBox6resultB.Text = "Success";
            textBox7resultB.Text = "Success";
            textBox8resultB.Text = "Success";
            textBox9resultB.Text = "Success";
            textBox10resultB.Text = "Success";

            if (textBox1input.Text == "Frank")
                textBox1resultA.Text = "Success";
            if (textBox1input.Text != "Frank")
                textBox1resultB.Text = "Fail";

            if (textBox2input.Text == "")
                textBox2resultA.Text = "Success";
            if (textBox2input.Text != "")
                textBox2resultB.Text = "Fail";
            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3resultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3resultB.Text = "Fail";
            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 == false)
                textBox4resultA.Text = "Success";
            if (val4 != false)
                textBox4resultB.Text = "fail";
            decimal val5A = Convert.ToDecimal(textBox5Ainput.Text);
            if (val5A == 2m)
                textBox5resultA.Text = "Success";
            decimal val5B = Convert.ToDecimal(textBox5Binput.Text);
            if (val5B == 2m)
                textBox5resultA.Text = "Success";
            if (val5B != 2m)
                textBox5resultB.Text = "Fail";
            if (val5B != 2m)
                textBox5resultA.Text = "Fail";
            if (textBox6input.Text == "Jones")
                textBox6resultA.Text = "Success";
            if (textBox6input.Text != "Jones")
                textBox6resultB.Text = "Fail";
            decimal val7 = Convert.ToDecimal(textBox7input.Text);
            if (val7 > 0m)
                textBox7resultA.Text = "Success";
            if (val7 == 0m)
                textBox7resultB.Text = "Fail";
            decimal val8A = Convert.ToDecimal(textBox8Ainput.Text);
            if (val8A == 1m)
                textBox8resultA.Text = "Success";
            if (val8A != 1m)
                textBox8resultB.Text = "Fail";
            decimal val8B = Convert.ToDecimal(textBox8Binput.Text);
            if (val8B > 1m)
                textBox8resultA.Text = "Success";
            if (val8B == 1m)
                textBox8resultB.Text = "Fail";
            if (val8B == 1m)
                textBox8resultA.Text = "Fail";
            decimal val9 = Convert.ToDecimal(textBox9input.Text);
            if (val9 >= 500m)
                textBox9resultA.Text = "Success";
            if (val9 < 500m)
                textBox9resultB.Text = "Fail";
            decimal val10A = Convert.ToDecimal(textBox10Ainput.Text);
            if (val10A <= 3m)
                textBox10resultA.Text = "Success";
            if (val10A > 3m)
                textBox10resultA.Text = "Fail";
            if (val10A > 3m)
                textBox10resultB.Text = "Fail";
            decimal val10B = Convert.ToDecimal(textBox10Binput.Text);
            
            if (val10B != 3m)
                textBox10resultB.Text = "Fail";
            
        }
    }
}
