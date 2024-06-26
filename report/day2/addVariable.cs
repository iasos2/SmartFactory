namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //두 정수 value1, value2 입력 받아 그 합을 출력하라~!!
            int value1 = Int32.Parse(Console.ReadLine());
            int value2 = Int32.Parse(Console.ReadLine());

            int result = value1 + value2;
            Console.WriteLine(result);
        }
    }
}
