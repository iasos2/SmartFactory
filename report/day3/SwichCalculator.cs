
namespace StringPrint03_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫 번째 숫자를 입력하세요: ");
            int value1 = Int32.Parse(Console.ReadLine());

            Console.Write("연산자 (+, -, *, /)를 입력하세요: ");
            string op = Console.ReadLine();
            //코딩(if나 switch~case

            Console.Write("두 번째 숫자를 입력하세요: ");
            int value2 = Int32.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(value1 + value2);
                    break;
                case "-":
                    Console.WriteLine(value1 - value2);
                    break;
                case "*":
                    Console.WriteLine(value1 * value2);
                    break;
                case "/":
                    Console.WriteLine((double)value1 / value2);
                    break;
            }

        }
    }
}
