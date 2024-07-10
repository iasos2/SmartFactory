
namespace StringPrint11_5
{
    internal class Program
    {
            // 1단계 : 재귀적인 방법 (Recursive)
            static int Factorial(int n)

            {

                if (n == 1) return n;

                else return n * Factorial(n - 1);

            }

            static void Main(string[] args)

            {

                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(Factorial(n));

            }
        // 2단계 : 다이나믹 방법 (Dynamic Algorithm) 
        class Dynamic
        {
            static long[] arr;
            public void FacDyna(int n)
            {
                arr = new long[n + 1];
                arr[0] = 1;

                for (int i = 1; i <= n; i++)
                {
                    arr[i] = i * arr[i - 1];
                }

                Console.WriteLine(arr[n]);
            }
        }
        internal class Program2
        {
            static void Main(string[] args)
            {
                Dynamic dyn = new Dynamic();
                dyn.FacDyna(int.Parse(Console.ReadLine()));
            }
        }
    }
}
