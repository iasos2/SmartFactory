namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = Int32.Parse(Console.ReadLine());  //변수 선언과 동시 초기화

            if (value == 100)
            {
                Console.WriteLine("if 로직 실행");
            }
            else if (value == 200)
            {
                Console.WriteLine("else if 로직 실행");
            }
            else
            {
                Console.WriteLine("else 로직 실행");

        }
        }
}
