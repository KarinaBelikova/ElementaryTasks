using System;
namespace Task2Envelopes
{
    public class UI
    {
        public static double[] InputEnvelopesData()
        {
            double[] parameters = new double[4];
            Console.WriteLine("Input width and height for two envelopes: ");         
            
            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = double.Parse(Console.ReadLine());
                if (!Validator.IsCorrectEnvelopeSide(parameters[i]))
                {
                    UI.IncorrectInput();
                }
            }

            return parameters;
        }

        public static void Display(string message)
        {
            Console.WriteLine($"{message}");
        }

        public static void IncorrectInput()
        {
            Console.WriteLine("Envelope side must be more than zero ");
        }

        public static void ShowErrorMessage(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }

    }
}
