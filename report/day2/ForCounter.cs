namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            //1. 초기화 조건 2. 종료조건
            for (int i = 0; i < 3; i++)
            {
                //counter = counter + i + 1;
                counter += i + 1;
            }
            Console.WriteLine(counter);
        }
    }
}
