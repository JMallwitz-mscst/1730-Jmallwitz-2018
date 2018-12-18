using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmallwitz3d1
{
    public class Ex3dCalculations
    {
        public static string ArrayToString(int[] values)
        {
            StringBuilder sbResult = new StringBuilder(200);
            string sbResult = "";
            foreach (int element in values)
            {
               sbResult = values + " ";
               
            }

            // Create StringBuilder object: sbResult
            // loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result
            string result = sbResult.ToString();
            return result.Remove(", ");
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter
            int count = 0;
            for (int i = 0; i > 10; i++)
            {
                int i = 3;
                Console.WriteLine(i);   // output: 3
                Console.WriteLine(i++); // output: 3
                Console.WriteLine(i);
            }
            return count;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter
            int count = 0;
            for (int i = 0; i > 10; i++)
            {
                int i = 3;
                Console.WriteLine(i);   // output: 3
                Console.WriteLine(i++); // output: 3
                Console.WriteLine(i);
            }
            return count;
        }
    }
}
