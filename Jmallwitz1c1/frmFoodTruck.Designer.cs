namespace Jmallwitz1c1
{
    partial class frmFoodTruck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiniDonuts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiniDonutsSubtotal = new System.Windows.Forms.TextBox();
            this.txtCheeseSteaksSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheeseSteaks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtpretaxtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini Donuts:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMiniDonuts
            // 
            this.txtMiniDonuts.Location = new System.Drawing.Point(133, 40);
            this.txtMiniDonuts.Name = "txtMiniDonuts";
            this.txtMiniDonuts.Size = new System.Drawing.Size(47, 20);
            this.txtMiniDonuts.TabIndex = 1;
            this.txtMiniDonuts.Text = "0";
            this.txtMiniDonuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x $3.00 =";
            // 
            // txtMiniDonutsSubtotal
            // 
            this.txtMiniDonutsSubtotal.Location = new System.Drawing.Point(255, 40);
            this.txtMiniDonutsSubtotal.Name = "txtMiniDonutsSubtotal";
            this.txtMiniDonutsSubtotal.ReadOnly = true;
            this.txtMiniDonutsSubtotal.Size = new System.Drawing.Size(51, 20);
            this.txtMiniDonutsSubtotal.TabIndex = 3;
            this.txtMiniDonutsSubtotal.TabStop = false;
            this.txtMiniDonutsSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCheeseSteaksSubtotal
            // 
            this.txtCheeseSteaksSubtotal.Location = new System.Drawing.Point(255, 66);
            this.txtCheeseSteaksSubtotal.Name = "txtCheeseSteaksSubtotal";
            this.txtCheeseSteaksSubtotal.ReadOnly = true;
            this.txtCheeseSteaksSubtotal.Size = new System.Drawing.Size(51, 20);
            this.txtCheeseSteaksSubtotal.TabIndex = 7;
            this.txtCheeseSteaksSubtotal.TabStop = false;
            this.txtCheeseSteaksSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "x $7.00 =";
            // 
            // txtCheeseSteaks
            // 
            this.txtCheeseSteaks.Location = new System.Drawing.Point(133, 66);
            this.txtCheeseSteaks.Name = "txtCheeseSteaks";
            this.txtCheeseSteaks.Size = new System.Drawing.Size(47, 20);
            this.txtCheeseSteaks.TabIndex = 5;
            this.txtCheeseSteaks.Text = "0";
            this.txtCheeseSteaks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cheese Steaks:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(54, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtpretaxtotal
            // 
            this.txtpretaxtotal.Location = new System.Drawing.Point(255, 92);
            this.txtpretaxtotal.Name = "txtpretaxtotal";
            this.txtpretaxtotal.ReadOnly = true;
            this.txtpretaxtotal.Size = new System.Drawing.Size(51, 20);
            this.txtpretaxtotal.TabIndex = 9;
            this.txtpretaxtotal.TabStop = false;
            this.txtpretaxtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(255, 118);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(51, 20);
            this.txtTax.TabIndex = 10;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(255, 144);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(51, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pretax Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tax:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(149, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFoodTruck
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 287);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtpretaxtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCheeseSteaksSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCheeseSteaks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMiniDonutsSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiniDonuts);
            this.Controls.Add(this.label1);
            this.Name = "frmFoodTruck";
            this.Text = "Jmallwitz1c1: Food Truck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiniDonuts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiniDonutsSubtotal;
        private System.Windows.Forms.TextBox txtCheeseSteaksSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheeseSteaks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtpretaxtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

