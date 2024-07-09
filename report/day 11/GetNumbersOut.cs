

namespace StringPrint11_2
{
    internal class Program
    {
        //static void GetNumbers(out int x, out int y)
        //{
        //    x = 0;
        //    y = 0;
        //}
        static void GetValue(out int x)
        {
            x = 1;
        }
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //GetNumbers(out a, out b);

            //Console.WriteLine($"a에 저장된 값은 {a} 입니다.");
            //Console.WriteLine($"b에 저장된 값은 {b} 입니다.");
            int a;
            GetValue(out a);
            Console.WriteLine($"a에 저장된 값은 {a}");
        }
    }
}
