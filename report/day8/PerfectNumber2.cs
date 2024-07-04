using System.Diagnostics.CodeAnalysis;

namespace StringPrint08_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //완전수구하기
            //6 --> 1 + 2 + 3
            //8 --> 1+ 2 + 4 --> 7(x)

            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i < number ; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            //판별
            if (number == sum)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
