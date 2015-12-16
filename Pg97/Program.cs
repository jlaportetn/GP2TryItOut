using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg97
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            GenerateNumbers();
            PrintNumbers(numbers);
            PrintReverse(numbers);
            Console.ReadKey();
        }
        static int[] GenerateNumbers()
        {
            int[] iNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            {
                return iNumbers;
            }
        }
        static void PrintNumbers(int[] numbers)
        {
            for (int iPrint = numbers[0]; iPrint <= 10; iPrint++)
            {
                Console.WriteLine(iPrint);
            }
        }
        static void PrintReverse(int[]numbers)
        {
            for (int reverse = numbers[9]; reverse > 0; reverse--)
            {
                Console.WriteLine(reverse);
            }
        }
    }

}
