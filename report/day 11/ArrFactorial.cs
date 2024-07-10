using System.Runtime.InteropServices;

namespace StringPrint11_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] arr = new int[n + 1];

            arr[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                arr[i] = i * arr[i - 1];
            }
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
