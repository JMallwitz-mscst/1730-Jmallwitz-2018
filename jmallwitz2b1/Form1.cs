using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmallwitz2b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal AmountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal Australianrate = 0.72m;
            decimal AustraliaUSD = AmountAustralia * Australianrate;
            decimal AmountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal Brazilrate = 0.25m;
            decimal BrazilUSD = AmountBrazil * Brazilrate;
            decimal AmountJapan = Convert.ToDecimal(txtAmountJapan.Text);
            decimal Japanrate = 0.0088m;
            decimal JapanUSD = AmountJapan * Japanrate;
            decimal Koreaamount = Convert.ToDecimal(txtKoreaamount.Text);
            decimal Korearate = 0.00089m;
            decimal KoreaUSD = Koreaamount * Korearate;
            decimal USDTotal = AustraliaUSD + BrazilUSD + JapanUSD + KoreaUSD;
            txtAustraliaUSD.Text = Convert.ToDecimal(AustraliaUSD).ToString("0.00");
            txtBrazilUSD.Text = Convert.ToDecimal(BrazilUSD).ToString("0.00");
            txtJapanUSD.Text = Convert.ToDecimal(JapanUSD).ToString("0.00");
            txtKoreaUSD.Text = Convert.ToDecimal(KoreaUSD).ToString("0.00");
            txtUSDTotal.Text = Convert.ToDecimal(USDTotal).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountBrazil.Text = "0.00";
            txtAmountJapan.Text = "0.00";
            txtKoreaamount.Text = "0.00";
            txtAustraliaUSD.Text = "0.00";
            txtBrazilUSD.Text = "0.00";
            txtJapanUSD.Text = "0.00";
            txtKoreaUSD.Text = "0.00";
            txtUSDTotal.Text = "0.00";
        }
    }
}
