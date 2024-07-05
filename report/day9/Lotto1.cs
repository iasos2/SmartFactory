
using System;
using System.Runtime.InteropServices;

namespace StringPrint09_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] number = new int[6];
            int extra = 0;
            Console.Write("로또번호 : ");
            for (int i = 0; i < 6; i++)
            {
                number[i] = random.Next(1, 46);
                Console.Write($"{number[i]} ");
            }
            Console.WriteLine();
            extra = random.Next(1, 46);
            Console.WriteLine($"보너스번호 : {extra}");
        }
    }
}
