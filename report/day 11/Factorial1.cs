
namespace StringPrint11_3
{
    internal class Program //팩토리얼
    {
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(Factorial(a));
        }
    }
}
