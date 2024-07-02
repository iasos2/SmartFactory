//변수 교환(a, b값을 입력 받은 후, b와 a 값을 교환)
namespace VariableChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{a} {b}");

            //변수교환
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"{a} {b}");
        }
    }
}
