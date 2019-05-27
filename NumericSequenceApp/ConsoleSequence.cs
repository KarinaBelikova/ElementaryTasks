using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceApp
{
    class ConsoleSequence
    {
        #region Constructors

        public ConsoleSequence(int[] array)
        {
            Print(array);
        }

        #endregion

        #region Methods

        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write("{0} ", array[i]);
                }
                else
                {
                    Console.Write("{0}, ", array[i]);
                }

                Console.WriteLine();
            }
        }

        #endregion

    }
}
