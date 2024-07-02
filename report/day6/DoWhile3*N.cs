namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            do
            {
                Console.WriteLine($"3 * {k} = {3 * k}");
                k++;
            } while (k < 10);
        }
    }
}
