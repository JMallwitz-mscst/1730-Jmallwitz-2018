using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmallwitz2e1
{
    public class LogicalOperations
    {
        public static bool Q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }
        public static bool Q02(int timeInservice)
        {
            return timeInservice <= 4 || timeInservice >= 12;
        }
        public static bool Q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }
        public static bool Q04(bool isValid, int years, int counter)
        {
            return isValid == true & counter++ < years;
        }
        public static bool Q05(bool isValid, int years, int counter)
        {
            return isValid == true || counter++ < years;
        }
        public static bool Q06(bool isValid, int years, int counter)
        {
            return isValid == true | counter++ < years;
        }
        public static bool Q07(bool isValid, DateTime startDate, DateTime expirationDate, DateTime date)
        {
            return date > startDate && date < expirationDate || isValid == true;
        }
        public static bool Q08(decimal thisYTD, decimal lastYTD, string empType, int startYear, int currentYear)
        {
            return ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
                ;
        }
        public static bool Q09(int years, int counter)
        {
            return !(counter++ >= years);
        }
        public static bool Q10(int a, int b, int c, int d)
        {
            return
                a > b && b < c || c < d
                ;
        }
        public static bool Q11(bool member, decimal price, float weight)
        {
            return member == true || price >= 25 || weight <= 1.0
                ;
        }
        public static bool Q12(bool member, decimal price, float weight)
        {
            return member == true || price >= 25 && weight < 1.0
                ;
        }
        public static bool Q13(string shipState, string itemType)
        {
            return !(shipState != "MN" || itemType == "clothing" || itemType == "food");
        }
    }
}
