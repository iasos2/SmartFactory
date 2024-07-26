namespace StringPrint22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 4, 6, 8};

            int even = numbers.LastOrDefault(n => n % 2 == 0);

            if(even == 0)
            {
                Console.WriteLine("짝수가 없다.");
            }
            else
            {
                Console.WriteLine(even);
            }
        }
    }
}
