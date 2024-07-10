
    namespace StringPrint11_12
{
    class ClassA
    {
        private int a;

        private void PrintOutA()
        {
            Console.WriteLine(a);
        }
    }
    class ClassB
    {
        public int b;

        public void PrintOutB()
        {
            Console.WriteLine(b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA x = new ClassA();    //객체 만들기는 지장이 없다.
            //x.a = 123;
            //x.PrintOutA();
            ClassB y = new ClassB();
            y.b = 123;
            y.PrintOutB();
        }
    }
}
