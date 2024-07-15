namespace StringPrint14_1
{
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }

        private void Test()
        {
            Plus(100, 200);
        }
    }
    internal class Program
    {
        delegate int Compute(int a, int b);
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Plus(1, 2);
            Compute compute = cal.Plus;
            Console.WriteLine(compute(5, 7));
            compute = cal.Minus;
            Console.WriteLine(compute(5, 7));
        }
    }
}
