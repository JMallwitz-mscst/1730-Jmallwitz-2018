using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmallwitz3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            if (index == 1)
            {
                return "Sunday";
            }
            else if (index == 2)
            {
                return "Monday";
            }
            else if (index == 3)
            {
                return "Tuesday";
            }
            else if (index == 4)
            {
                return "Wednesday";
            }
            else if (index == 5)
            {
                return "Thursday";
            }
            else if (index == 6)
            {
                return "Friday";
            }
            else if (index == 7)
            {
                return "Saturday";
            }
            return "Invalid input";
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search);

            {
                if (index == Int32.Parse("Sunday"))
                {
                    return "Closed";
                }
                if (index == Int32.Parse("Monday"))
                {
                    return "10am - 6pm";
                }
                else if (index == Int32.Parse("Tuesday"))
                {
                    return "10am - 6pm";
                }
                else if (index == Int32.Parse("Wednesday"))
                {
                    return "10am - 6pm";
                }
                else if (index == Int32.Parse("Thursday"))
                {
                    return "10am - 9pm";
                }
                else if (index == Int32.Parse("Friday"))
                {
                    return "10am - 6pm";
                }
                else if (index == Int32.Parse("Saturday"))
                {
                    return "8am - 4pm";
                }

            }
            return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            decimal sum = 0.0m;
            foreach (decimal number in numbers)
                sum += number;
            return Convert.ToInt32(sum);
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.00;

            for (int count = 0; count < numbers; count++)
                sum += numbers[count];
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.00;
            if (numbers[count] > 0)
            {
                for (int count = 0; count < numbers; count++)
                    sum += numbers[count] / count;
                return sum;
            }
            return Double.Parse("Invalid input");
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);

                foreach Double.Parse(avg = 0; avg < numbers; avg++;) {
                    if (numbers >= avg)
                        aboveAvgList.Add(numbers);
                }

            }

            return aboveAvgList.ToArray();
        }
    }
}
