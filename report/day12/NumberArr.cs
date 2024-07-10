
namespace StringPrint12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 100, 200, 300, 400, 500 };

            foreach(int n in  numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
