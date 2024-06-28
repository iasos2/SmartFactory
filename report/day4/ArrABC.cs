
namespace StringPrint04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            Console.WriteLine(ch);

            char[] arr = new char[3];
            arr[0] = 'a';
            arr[1] = 'b';
            arr[2] = 'c';

            Console.WriteLine($"{arr[0]}{arr[1]}{arr[2]}");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
