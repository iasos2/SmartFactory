namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cen = Int32.Parse(Console.ReadLine());

            //double F = (double)9 / 5 * cen + 32;
            double F = 3.141592;
            //출력
            Console.WriteLine($"{F:F2}");

        }
    }
}
