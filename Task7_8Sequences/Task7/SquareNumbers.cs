using System.Collections.Generic;

namespace Task7_8Sequences
{
    public class SquareNumbers //TODO : IEnumerable // GetEnumerator
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

        public IEnumerable<int> GetSequence()   //TODO Method if(GetNextNumber)  
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
