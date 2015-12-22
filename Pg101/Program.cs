using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the position in the Fibonacci Sequence you would like to display (1-10)");
            int userEntry = Convert.ToInt32(Console.ReadLine());
            int output = Fibonacci(userEntry);
            Fibonacci(userEntry);
            Console.WriteLine("The number in position " + userEntry +" of the Fibonacci Sequence is " + output);
            Console.ReadKey();

        }
        static int Fibonacci(int userEntry)
        {
            int[] numbersOfFib = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            if (userEntry == 1)
                return 1;
            return numbersOfFib[userEntry - 1];
        }
    }
}
