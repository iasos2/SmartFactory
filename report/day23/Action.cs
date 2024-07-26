namespace StringPrint22_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine(result);

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine(pi);
            };
            act3(22.0, 7.0);
        }
    }
}
