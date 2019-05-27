using System.Collections.Generic;

namespace Task7_8Sequences
{
    public class Fibonacci
    {
        #region Properties

        private int LowLimit { get; set; }
        private int UpLimit { get; set; }

        #endregion

        #region Constructor

        public Fibonacci(int lowLimit, int upLimit)
        {
            LowLimit = lowLimit;
            UpLimit = upLimit;
        }

        #endregion

        #region Iterator

        public IEnumerable<int> GetSequence()
        {
            int previous = 0;
            int next = 1;
            while (previous + next <= UpLimit)
            {
                int sum = previous + next;
                previous = next;
                next = sum;
                if (next > LowLimit)
                {
                    yield return next;
                }
            }
        }

        #endregion

    }
}
