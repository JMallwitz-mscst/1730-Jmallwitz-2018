using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jacobmallwitz1f1
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void picKoreaDim_Click(object sender, EventArgs e)
        {

        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            lblCurrency.Text = btnBrazil.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.24";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();

        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            lblCurrency.Text = btnBrazil.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.24";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.72";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnKorea.BackgroundImage = picKoreaDim.Image;
            lblCurrency.Text = btnJapan.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.0089";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnKorea_Click(object sender, EventArgs e)
        {
            btnKorea.BackgroundImage = picKorea.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            lblCurrency.Text = btnKorea.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.00089";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUSD.Text = (Convert.ToDecimal(txtCurrency.Text) *
                               Convert.ToDecimal(txtRate.Text)).ToString("0.00");
            txtTotal.Text = txtUSD.Text;
            lblEquation.Text = lblEquation.Text + " + " + txtTotal.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
            txtTotal.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
