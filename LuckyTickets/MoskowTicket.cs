using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class MoskowTicket : ILuckyAlgorithm
    {
        public bool isLuckyTicket(Ticket ticket)
        {
            int firstPartSum = 0;
            int secondPartSum = 0;

            for (int i = 0; i < ticket.Length; i++)
            {
                if (i < 3)
                    firstPartSum += Convert.ToInt32(ticket[i]);
                else
                    secondPartSum += Convert.ToInt32(ticket[i]);
            }

            return firstPartSum == secondPartSum;
        }
    }
}
