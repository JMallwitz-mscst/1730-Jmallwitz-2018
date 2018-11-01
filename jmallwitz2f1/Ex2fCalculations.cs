using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmallwitz2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            // #1: if
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100)
            {
                discountpercent = 0.2m;
            }
            return discountpercent.ToString("n2");
        }
        public static string Calc02(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            // #2: if {block}
            subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountpercent = 0.2m;
                status = "Bulk rate: ";
            }
            return status + discountpercent.ToString("n2");
        }

        public static string Calc03(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountpercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountpercent = 0.3m;
            else if (subtotal >= 300m)
                discountpercent = 0.4m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountpercent = 0m;
            if (subtotal >= 300m)
                discountpercent = 0.4m;
            else if (subtotal >= 200m)
                discountpercent = 0.3m;
            else if (subtotal >= 100m)
                discountpercent = 0.2m;
            else
                discountpercent = 0.1m;
            return discountpercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0.0m;
            decimal discountpercent = 0.0m;
            subtotal = Decimal.Parse(inputA);
            string customertype = inputB;
            discountpercent = 0m;
            if (customertype == "R")
            {
                if (subtotal >= 100m)
                    discountpercent = 0.2m;
                else
                    discountpercent = 0.1m;
            }
            else
                discountpercent = 0.4m;
            return discountpercent.ToString("n2");
        }
        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0.0m;
            if (inputA != "" && inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                string quantity = inputB;
                decimal subtotal = Decimal.Parse(inputA) * Decimal.Parse(quantity);
                decimal Shipping = 0.0m;
                total = Shipping + Decimal.Parse(inputA) * Decimal.Parse(quantity);
                if (Decimal.Parse(inputA) * Decimal.Parse(quantity) < 50.0m)
                {
                    Shipping = 5.0m;
                }
                else { 
                    Shipping = 0.0m;
                }
                
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal total = 0.0m;
            if (inputA != "" && inputB != "" && Decimal.Parse(inputB) >= Decimal.Parse(inputA))
            {
                decimal start = Decimal.Parse(inputA);
                decimal end = Decimal.Parse(inputB);
                decimal rate = 0.1m;
                decimal difference = end - start;
                total = difference * rate;
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal total = 0m;
            if (inputA != "" && inputB != "" && Decimal.Parse(inputA) > 0m && Decimal.Parse(inputB) > 0m)
            {
                decimal Sum1 = Decimal.Parse(inputA);
                decimal Sum2 = Decimal.Parse(inputB);
                if (Sum2 >= Sum1)
                {
                    total = Sum2 / Sum1;
                }
                if (Sum1 >= Sum2)
                {
                    total = Sum1 / Sum2;
                }
                return total.ToString("n2");
            }
            return "Invalid input";
        }
    }
}    

