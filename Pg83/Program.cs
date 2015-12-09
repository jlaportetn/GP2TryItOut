using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg83
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int[] copyOfNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                copyOfNumbers[i] = numbers[i];
                Console.WriteLine(numbers[i]);
            }
            for (int i = 0; i < copyOfNumbers.Length; i++)
            {
                Console.WriteLine(copyOfNumbers[i]);
            }
            Console.ReadKey();
        }
    }
}
