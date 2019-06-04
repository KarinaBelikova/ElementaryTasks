using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    public class Fibonacci
    {
        #region Properties

        public int Number { get; set; }

        #endregion

        // IEnumerable yield

        

        public static int GetFibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }

            int fibonacci = 1;
            int previous = 1;

            for (int i = 2; i < n; i++)
            {
                int temp = fibonacci;
                fibonacci += previous;
                previous = temp;
            }

            return fibonacci;
        }

        public static void Print(int min, int max)
        {
            while (min <= max)
            {
                Console.Write("{0}, ", Fibonacci.GetFibonacci(min));
                min++;
            }
        }
    }
}
