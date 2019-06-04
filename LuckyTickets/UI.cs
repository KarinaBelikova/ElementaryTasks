using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6LuckyTickets
{
    public class UI
    {
        public static void GetPath()
        {

        }

        public static void Display(string message)
        {
            Console.WriteLine($"{message}");
        }      

        public static void ShowErrorMessage(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
        
    }
}
