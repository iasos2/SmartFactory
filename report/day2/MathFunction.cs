namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            Console.WriteLine(Math.PI);

            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:F2}");
        }
    }
}
