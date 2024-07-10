
using System.Numerics;

namespace StringPrint11_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            BigInteger[] arr = new BigInteger[n + 1];

            arr[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                arr[i] = i * arr[i - 1];
            }
            foreach (BigInteger i in arr)
                Console.Write(i + " ");
        }
    }
}
