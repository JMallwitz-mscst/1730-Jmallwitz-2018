using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmallwitz2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcbutton_Click(object sender, EventArgs e)
        {
            //decimal subtotal = 0.0m;
            //decimal discountpercent = 0.0m;
            // #1
            //subtotal = Decimal.Parse(textBox2.Text);
            //if (subtotal >= 100)
            //{
            //  discountpercent = 0.2m;
            //}
            textBox1.Text = Ex2fCalculations.Calc01(textBox2.Text);
            // #2
            //subtotal = Decimal.Parse(textBox4.Text);
           // string status = "Standard rate: ";
            //if (subtotal >= 100m)
           // {
             //   discountpercent = 0.2m;
               // status = "Bulk rate: ";
           // }
            textBox3.Text = Ex2fCalculations.Calc02(textBox4.Text);
            // #3
            //subtotal = Decimal.Parse(textBox6.Text);
            //discountpercent = 0m;
            //if (subtotal >= 100m)
              //  discountpercent = 0.2m;
            //else
                //discountpercent = 0.1m;
            textBox5.Text = Ex2fCalculations.Calc03(textBox6.Text);
            // #4
            // subtotal = Decimal.Parse(textBox8.Text);
            // discountpercent = 0m;
            // if (subtotal >= 100m && subtotal < 200m)
            //     discountpercent = 0.2m;
            // else if (subtotal >= 200m && subtotal < 300)
            //     discountpercent = 0.3m;
            // else if (subtotal >= 300m)
            //     discountpercent = 0.4m;
            // else
            //     discountpercent = 0.1m;
            textBox7.Text = Ex2fCalculations.Calc04(textBox8.Text);
            // #5
            //subtotal = Decimal.Parse(textBox10.Text);
            //discountpercent = 0m;
            //if (subtotal >= 300m)
            //    discountpercent = 0.4m;
            //else if (subtotal >= 200m)
            //    discountpercent = 0.3m;
            //else if (subtotal >= 100m)
            //    discountpercent = 0.2m;
            //else
            //    discountpercent = 0.1m;
            textBox9.Text = Ex2fCalculations.Calc05(textBox10.Text);
            // #6
            //subtotal = Decimal.Parse(textBox12.Text);
            //string customertype = textBox13.Text;
            //discountpercent = 0m;
            //if (customertype == "R")
            //{
            //    if (subtotal >= 100m)
            //        discountpercent = 0.2m;
            //    else
            //        discountpercent = 0.1m;
            //}
            //else
            //    discountpercent = 0.4m;
            textBox11.Text = Ex2fCalculations.Calc06(textBox12.Text, textBox13.Text);
            // #7
            textBox15.Text = Ex2fCalculations.Calc07(textBox14.Text);
            // #8
            textBox17.Text = Ex2fCalculations.Calc08(textBox18.Text, textBox16.Text);
            // #9
            textBox21.Text = Ex2fCalculations.Calc09(textBox20.Text, textBox19.Text);
            // #10
            textBox23.Text = Ex2fCalculations.Calc09(textBox24.Text, textBox12.Text);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
