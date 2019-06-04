using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Envelopes
{
    public class Validator
    {
        public static bool IsCorrectEnvelopeSide(double envelopeSide)
        {
            return (envelopeSide > 0);
        }
    }
}
