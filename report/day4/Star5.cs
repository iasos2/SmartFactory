
namespace StringPrint04_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
            for (int j = 5; j > i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    }
}//*****
//  ****
//   ***
//    **
//     *
