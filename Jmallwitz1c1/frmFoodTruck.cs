using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jmallwitz1c1
{
    public partial class frmFoodTruck : Form
    {
       
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtMiniDonutsSubtotal.Text = (
                3.0m * Convert.ToDecimal(txtMiniDonuts.Text)
                ).ToString("0.00");
             txtCheeseSteaksSubtotal.Text = (
                7.0m * Convert.ToDecimal(txtCheeseSteaks.Text)
                ).ToString("0.00");
            txtpretaxtotal.Text = (
                Convert.ToDecimal(txtMiniDonutsSubtotal.Text) +
                Convert.ToDecimal(txtCheeseSteaksSubtotal.Text)
                ).ToString("0.00");
            txtTax.Text = (
              .08375m * Convert.ToDecimal(txtpretaxtotal.Text)).ToString("0.00");
            txtTotal.Text = (
                Convert.ToDecimal(txtpretaxtotal.Text) +
                Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMiniDonuts.Text = "0";
            txtCheeseSteaks.Text = "0";
            txtMiniDonutsSubtotal.Text = "";
            txtCheeseSteaksSubtotal.Text = "";
            txtpretaxtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtMiniDonuts.Focus();
        }
    }
}
