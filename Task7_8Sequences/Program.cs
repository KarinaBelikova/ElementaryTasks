using System;

namespace Task7_8Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write("Enter number of task (7 or 8): ");
                int task = Convert.ToInt32(Console.ReadLine());

                switch (task)
                {
                    case 7:
                        try
                        {
                            Console.Write("Enter number: ");
                            int[] paramsTask7 = new int[2];

                            paramsTask7[0] = 7;
                            paramsTask7[1] = Int32.Parse(Console.ReadLine());

                            if (Validator.IsCorrect7Task(paramsTask7))
                                SequenceUI.PrintSquares(paramsTask7[1]);
                        }
                        catch (FormatException)
                        {
                            SequenceUI.Incorrect();
                        }
                        break;
                    case 8:
                        try
                        {
                            int[] paramsTask8 = new int[3];

                            paramsTask8[0] = 8;
                            Console.Write("Low limit: ");
                            paramsTask8[1] = Int32.Parse(Console.ReadLine());

                            Console.Write("Up limit: ");
                            paramsTask8[2] = Int32.Parse(Console.ReadLine());

                            if (Validator.IsCorrect8Task(paramsTask8))
                                SequenceUI.PrintFibonacci(paramsTask8[1], paramsTask8[2]);
                        }
                        catch (FormatException)
                        {
                            SequenceUI.Incorrect();
                        }
                        break;
                    default:
                        SequenceUI.Incorrect();
                        break;
                }
            }

            else if (args.Length == 2)
            {
                try
                {
                    int[] array = Array.ConvertAll(args, int.Parse);

                    if (Validator.IsCorrect7Task(array))
                    {
                        int number = array[1];
                        SequenceUI.PrintSquares(number);
                    }
                }
                catch (FormatException)
                {
                    SequenceUI.ShowInstructionsParametors();
                }                

            }

            else if (args.Length == 3)
            {
                try
                {
                    int[] array = Array.ConvertAll(args, int.Parse);
                    if (Validator.IsCorrect8Task(array))
                    {
                        int lowLimit = array[1];
                        int upLimit = array[2];
                        SequenceUI.PrintFibonacci(lowLimit, upLimit);
                    }
                }
                catch (FormatException)
                {
                    SequenceUI.ShowInstructionsParametors();
                }                                                                             
            }
           
            Console.ReadKey();
        }
    }
}
