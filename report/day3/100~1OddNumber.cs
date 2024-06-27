namespace StringPrint03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            while (i >= 0)
            {
                if (i % 2 == 1)
                    Console.Write($"{i} ");
                i--;
            }
        }
    }
}
