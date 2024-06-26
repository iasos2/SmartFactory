namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting;    //변수선언
            Console.Write("이름을 입력해 주세요 : ");
            greeting = Console.ReadLine();   //값 할당, 초기화한다.

            Console.WriteLine($"당신의 이름은 {greeting}입니다.");    //출력!!
        }
    }
}
