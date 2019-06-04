using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Номер задания: ");
            int task = Convert.ToInt32(Console.ReadLine());

            switch (task)
            {
                case 1:
                    Console.Write("Задайте длину шахматной доски: ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Задайте ширину шахматной доски: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    ChessBoard board = new ChessBoard(width, height);
                    board.Print();
                    break;
                case 2:
                    string answer = "";
                    do
                    {
                        Console.Write("Задайте ширину 1 конверта: ");
                        double a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Задайте длину 1 конверта: ");
                        double b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Задайте ширину 2 конверта: ");
                        double c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Задайте длину 2 конверта: ");
                        double d = Convert.ToInt32(Console.ReadLine());

                        Envelope env1 = new Envelope(a, b);
                        Envelope env2 = new Envelope(c, d);

                        if (Envelope.IsPuts(env1, env2))
                            Console.WriteLine("Один конверт можно вложить в другой");
                        else
                            Console.WriteLine("Один конверт нельзя вложить в другой");

                        Console.Write("Хотите попробовать еще раз? (y - да, n - нет)");
                        answer = Console.ReadLine();
                    }
                    while (answer == "y");                
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
