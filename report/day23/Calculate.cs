namespace StringPrint22_16
{//Lamda
    internal class Program
    {
        delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            //Calculate calc = (inta, int b) => a+b;

            Calculate calc = delegate (int a, int b)
            { return a + b; };

            Console.WriteLine(calc(100, 200));
        }
    }
}
