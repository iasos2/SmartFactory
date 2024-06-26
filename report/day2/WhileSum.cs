namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
