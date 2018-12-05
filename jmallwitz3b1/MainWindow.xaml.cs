using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jmallwitz3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                ResultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
            }
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox1a.Text);
                decimal discountPercent;
                    Ex3bCalculations.GetDiscountPercentOut(subtotal, out discountPercent);
                ResultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox1a.Text);
            }
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months);
                ResultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }
            try
            {
                int months = Int32.Parse(this.inputTextBox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox3b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextBox3c.Text);
                decimal futureValue = 0m;
                    Ex3bCalculations.CalculateFutureValueRef(
                    monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                ResultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox3a.Text + "\n"
                    + this.inputTextBox3b.Text + "\n"
                    + this.inputTextBox3c.Text + "\n");
            }
            try
            {
                double fahrenheit = Double.Parse(this.inputTextBox4a.Text);
                double celsius = Ex3bCalculations.FahrenheittoCelsius(fahrenheit);
                ResultTextBox4.Text = celsius.ToString("f3");
            }
            catch
            {
                ResultTextBox4.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text);
            }
            try
            {
                double celsius = Double.Parse(this.inputTextBox5a.Text);
                double fahrenheit;
                Ex3bCalculations.CelsiustoFahrenheit(celsius, out fahrenheit);
                ResultTextBox5.Text = celsius.ToString("f3");
            }
            catch
            {
                ResultTextBox5.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text);
            }
            try
            {
                decimal hours = Decimal.Parse(this.inputTextBox6a.Text);
                decimal payrate = Decimal.Parse(this.inputTextBox6b.Text);
                decimal Grosspay = Ex3bCalculations.GrossPay(hours, payrate);
                ResultTextBox6.Text = Grosspay.ToString("f3");
            }
            catch
            {
                this.ResultTextBox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text + "\n");
            }
            try
            {
                this.ResultTextBox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                this.ResultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox7a.Text);

            }
            try
            {
                decimal rate = Decimal.Parse(this.inputTextBox8b.Text);
                this.ResultTextBox8.Text =
                    Ex3bCalculations.STRGrossPay(this.inputTextBox8a.Text, rate).ToString("n2");
            }
            catch
            {
                this.ResultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text);
            }
        }
    }
}