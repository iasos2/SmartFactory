
namespace StringPrint11_1
{
    internal class Program
    {
        static int CallByValueDemo(int x)
        {
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("입력하신 정수의 값은 {0}입니다.", CallByValueDemo(inputNumber));
        }
    }
}
