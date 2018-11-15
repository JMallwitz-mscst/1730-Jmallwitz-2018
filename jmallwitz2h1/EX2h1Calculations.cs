using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jmallwitz2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            return result;

        }

        public static string DateCalc07(string strDate)
        {
            string result = "invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDueDate, string strcurrentDate)
        { 
        string result = "invalid input";
        DateTime currentDate = DateTime.Today;
        dueDate = DateTime.Parse(strDue);
        TimeSpan timeTillDue = dueDate - currentDate;
        return timeTillDue;
        }
        public static string DateCalc10(string strDueDate, string strcurrentDate)
        {
            string result = "invalid input";
            DateTime currentDate = DateTime.Today;
            dueDate = DateTime.Parse(strDue);
            TimeSpan timeTillDue = dueDate - currentDate;
            return timeTillDue;
        }
    }
}