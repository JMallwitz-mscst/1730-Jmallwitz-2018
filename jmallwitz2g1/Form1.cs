using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmallwitz2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1a)
            textBox2.Text = Ex2gCalculations.Switch01(textBoxinput1.Text);
            // 1b
            textBox3.Text = Ex2gCalculations.If01(textBoxinput1.Text);
            // 1c
            textBox4.Text = Ex2gCalculations.ElseIf01(textBoxinput1.Text);
            // 1d
            textBox5.Text = Ex2gCalculations.NestedIfElse01(textBoxinput1.Text);
            // 1e
            textBox6.Text = Ex2gCalculations.SwitchDefault01(textBoxinput1.Text);
            // 1f
            textBox7.Text = Ex2gCalculations.IfDefault01(textBoxinput1.Text);
            // 1g
            textBox8.Text = Ex2gCalculations.ElseIfDefault01(textBoxinput1.Text);
            // 1h
            textBox9.Text = Ex2gCalculations.NestedIfElseDefault01(textBoxinput1.Text);
            // 2a
            textBox10.Text = Ex2gCalculations.Switch02(textBoxinput2.Text);
            //2b
            textBox11.Text = Ex2gCalculations.If02(textBoxinput2.Text);
            //2c
            textBox12.Text = Ex2gCalculations.ElseIf02(textBoxinput2.Text);
            //2d
            textBox13.Text = Ex2gCalculations.NestedIfElse02(textBoxinput2.Text);
        }
    }
}
