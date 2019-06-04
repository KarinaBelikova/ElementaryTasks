using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class Ticket
    {
        private int[] _numbers;

        public int Length { get => _numbers.Length; }
        public ILuckyAlgorithm Algorithm { get; set; }

        public int this[int index]
        {
            get
            {
                return _numbers[index];
            }
            set
            {
                _numbers[index] = value;
            }
        }

        public Ticket(int[] numbers, ILuckyAlgorithm algorithm)
        {
            _numbers = numbers;
            Algorithm = algorithm;
        }

        public bool IsLucky()
        {
            return Algorithm.isLuckyTicket(this);
        }
    }
}
