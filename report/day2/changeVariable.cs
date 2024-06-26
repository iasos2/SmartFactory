namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = Int32.Parse(Console.ReadLine());
            int value2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{value1} {value2}");    //100 200

            int temp = value1;
            value1 = value2;
            value2 = temp;

            Console.WriteLine($"{value1} {value2}");    //200 100
        }
    }
}
