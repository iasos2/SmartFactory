namespace StringPrint11_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dynamic Program Factorial!!!!!!!!!
            int n = 5;
            int[] arr = new int[n + 1];

            arr[0] = 1; //이 코드가 핵심!!!!!

            for (int i = 1; i <= n; i++)
            {
                arr[i] = i * arr[i - 1];
            }
            Console.WriteLine(arr[n]);
        }
    }
}
