namespace StringPrint08_5
{
    internal class Program
    {
        static string PerfectNumber(int num)
        {
            int result = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    result += i;
                }
            }

            if (result == num)
            {
                return "yes";
            }
            else return "no";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PerfectNumber(8));
        }

    }

}
