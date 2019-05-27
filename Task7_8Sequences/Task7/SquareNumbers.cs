using System.Collections.Generic;

namespace Task7_8Sequences
{
    public class SquareNumbers
    {
        #region Fild
       
        private int _maxNumber;

        #endregion

        #region Constructors

        public SquareNumbers(int maxNumber)
        {
            _maxNumber = maxNumber;
        }

        #endregion

        #region Iterator

        public IEnumerable<int> GetSequence()
        {
            for (int i = 0; i < _maxNumber; i++)
            {
                if (i * i < _maxNumber)
                {
                    yield return i;
                }
            }
        }      
        #endregion  
    }
}
