using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg85
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 99, 43, 55, 88 };
            int sum = 0;
            float average = 0;

            foreach (int number in numbers)
            sum += number;
            average = (float)sum / numbers.Length;
            {
                Console.WriteLine("The sum of the numbers is " + sum);
                Console.WriteLine("The average of the numbers is " + average);
            }
            Console.ReadKey();
        }
    }
}
