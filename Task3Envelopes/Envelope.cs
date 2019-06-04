using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Envelopes
{
    public class Envelope : IComparable<Envelope>
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Envelope(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public int CompareTo(Envelope other)
        {
            if ((this.Height > other.Height) && (this.Width > other.Width))            
            {
                return 1;
            }
            else if ((this.Height == other.Height) && (this.Width == other.Width))
            {
                return 0;
            }
            else
                return -1;
        }
    }
}
