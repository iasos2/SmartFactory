using System.Runtime.InteropServices;

namespace StringPrint11_7
{
    internal class Program
    {
        static int Factorial(int n)
        {
            //4! : 4 * 3 * 2 * 1
            if (n == 1)
            {
                Console.WriteLine(n);
                return n;
            }
            else
            {
                Console.WriteLine(n);
                return n * Factorial(n - 1);    //4 * Factorial(3), 3 * Factorial(2) ...
            }

        }
        static void Main(string[] args)
        {
            //3! : 3 * 2 * 1
            //4! : 4 * 3 * 2 * 1
            int n = 5;
            //Factorial(n);
            Console.WriteLine($"\n{n} : Factorial 합 : {Factorial(n)}");
        }
    }
}

