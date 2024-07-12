namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //사각형 넓이(가로값과 높이를 입력값으로 받은 후 사각형의 넓이를 구하는 코드다.)

            //1. 변수선언 및 입력부
            Console.Write("가로값을 입력해 주세요 : ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("높이를 입력해 주세요 : ");
            int height = int.Parse(Console.ReadLine());

            //2. 알고리즘 수식
            int result = width * height; //수식

            //3. 출력부
            Console.WriteLine($"넓이는 {result} 입니다.");
        }
    }
}
