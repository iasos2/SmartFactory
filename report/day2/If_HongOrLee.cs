namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();  //변수 선언과 동시 초기화

            if (name == "홍길동")
            {
                Console.WriteLine("1. 나는 {0}입니다.", name);
            }
            else if (name == "이순신")
            {
                Console.WriteLine("2. 나는 {0}입니다.", name);
            }
            else
            {
                Console.WriteLine("3. 나는 {0}입니다.", name);


            }
        }
    }
}
