
using System;

namespace Task2Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Application.Run();
            }
            catch (FormatException e)
            {
                UI.ShowErrorMessage(e);
            }
           
        }

    }
}
