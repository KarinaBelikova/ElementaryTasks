using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class Envelope
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Envelope()
        {
            Length = 1;
            Width = 1;
        }

        public Envelope(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public static bool IsPuts (Envelope a, Envelope b)
        {
            if(a.Width <= b.Width && a.Length <= b.Length || a.Width <= b.Length && a.Length <= b.Width)
                return true;
            if (b.Width <= a.Width && b.Length <= a.Length || b.Length <= a.Width && b.Width <= a.Length)
                return true;
            else
                return false;
        }
    }
}
