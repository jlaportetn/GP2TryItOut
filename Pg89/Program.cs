using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg89
{
    public enum MonthsOfYear { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6,
                                July = 7, August = 8, September = 9, October = 10, November = 11, December = 12};
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a month by number (1 - 12)");
            var userEntry = Convert.ToInt32(Console.ReadLine());
            MonthsOfYear month = (MonthsOfYear)userEntry;
            {
                if ((userEntry >= 1) && (userEntry <= 12))
                {
                    Console.WriteLine("The month you selected is " + month);
                }
                else
                {
                    Console.WriteLine("Your selection is not valid.");
                }
                Console.WriteLine("Please press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
