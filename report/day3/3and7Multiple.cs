namespace StringPrint03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            for (int j = 1; j <= 100; j++)
            {
                if (j % 7 == 0)
                {
                    Console.Write($"{j} ");
                }
            }

            Console.WriteLine(sum);
        }
    }
}
