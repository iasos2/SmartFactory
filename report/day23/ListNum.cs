
namespace StringPrint22_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach(int n in result)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();
        }
    }
}
