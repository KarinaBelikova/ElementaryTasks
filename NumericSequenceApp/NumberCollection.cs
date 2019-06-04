using System;

namespace NumericSequenceApp
{
    class NumberCollection 
    {
        #region Filds

        private int[] _numbers;    // Числа, квадраты которых, меньше заданного числа
        private int _maxNumber;

        #endregion


        #region Constructors

        public NumberCollection(int maxNumber)
        {
            _maxNumber = maxNumber;
            GetSequence(_maxNumber);
        }

        #endregion

        #region Methods

        //public IEnumerable<int> GetSequence()
        //{
        //    for (int i = 0; i < _maxNumber; i++)
        //    {
        //        if (i * i < _maxNumber)
        //        {
        //            yield return i;
        //        }
        //    }
        //}

        /// <summary>
        /// Get sequence of numerics what squares less than max number
        /// </summary>
        /// <param name="max"> max number</param>
        /// <returns>array of numbers</returns>
        private int[] GetSequence(int maxNumber) 
        {
            double maxSqr = Math.Sqrt(maxNumber);       
            
            if (maxSqr % 1 > 0)
            {
                maxSqr--;
            }

            for (int i = 0; i < maxSqr; i++)
            {
                _numbers[i] = i++;
            }

            return _numbers;
        }

        #endregion
    }
}
