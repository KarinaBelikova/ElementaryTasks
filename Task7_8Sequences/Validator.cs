namespace Task7_8Sequences
{
    public class Validator
    {      
        public static bool IsCorrect7Task(int[] params7Task)
        {
            bool IsCorrect = false;

            if (params7Task[0] == 7 && params7Task[1] > 0)
            {
                IsCorrect = true;
            }

            return IsCorrect;
        }

        public static bool IsCorrect8Task(int[] params8Task)
        {
            if (params8Task[0] == 8 && params8Task[1] < params8Task[2])
                return true;

            return false;
        }
    }
}
