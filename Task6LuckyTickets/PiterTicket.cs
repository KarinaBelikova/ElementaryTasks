using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6LuckyTickets
{
    public class PiterTicket : ILuckyAlgorithm
    {        
        public bool isLuckyTicket(Ticket ticket)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < ticket.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    evenSum += Convert.ToInt32(ticket[i]);
                else
                    oddSum += Convert.ToInt32(ticket[i]);
            }

            return evenSum == oddSum;
        }
    }
}
