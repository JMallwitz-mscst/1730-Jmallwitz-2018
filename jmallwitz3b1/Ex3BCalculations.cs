using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmallwitz3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }
        public static void GetDiscountPercentOut(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }
        public static decimal CalculateFutureValue(decimal monthlyInvestment,
            decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) *
                    (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        public static void CalculateFutureValueRef(decimal monthlyInvestment,
            decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) *
                    (1 + monthlyInterestRate);
            }
        }
        public static double FahrenheittoCelsius(double fahrenheit)
        {
            double celsius = 0.0;
            if (fahrenheit != 32.0)
                celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
        public static void CelsiustoFahrenheit(double celsuis, out double fahrenheit)
        {
            
            if (celsuis != 0.0)
                fahrenheit = (celsuis * 9/5) + 32;
            
        }
        public static decimal GrossPay (decimal hours, decimal payrate)
        {
            decimal Grosspay = 0m;
            if (hours <= 40)
                Grosspay = hours * payrate;
            else
                Grosspay = (hours * payrate) + ((hours - 40m) * 1.5m);

            return Grosspay;
        }
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0m;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }
            return total;
        }
        public static decimal STRGrossPay(string strNumbers, decimal payrate)
        {
            string strGrosspay = (GrossPay * TotalHours).ToString("n2");
        }

    }
}
