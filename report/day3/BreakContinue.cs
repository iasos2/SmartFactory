namespace StringPrint03_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("다시 시작하겠습니까?");

                if (Console.ReadLine().ToLower() == "n")
                {
                    Console.WriteLine("종료합니다");
                    break;
                }
                else if (Console.ReadLine().ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("다른 키를 선택하셨습니다");
                }
            }
        }
    }
}
