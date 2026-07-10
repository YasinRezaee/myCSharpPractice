using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods20
{
    public static class MathShortcut
    {
        public static double AddUp(double a, double b)
        {
            double output = a + b;
            return output;
        }
        public static void Add(double x, double y)
        {
            Console.WriteLine($"the sum of {x} + {y} is {x+y}");
        }

        public static void CalculateMean(double[] dataNumbers) 
        {
            //dataNumbers.Sum(); this can sum a sequence of numbers
            double mean = 0;
            for (int i = 0; i < dataNumbers.Length; i++)
            {
                  mean += dataNumbers[i] / dataNumbers.Length;
                Console.WriteLine($"the mean is {mean}");
            }
        }
     public static string Greatings()
        {
            Console.WriteLine("what is your last name?");
            string name = Console.ReadLine();
            return name;
;        }
    }
}
