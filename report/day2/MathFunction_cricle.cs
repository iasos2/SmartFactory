namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 변수선언 및 초기화
            Console.Write("반지름 값을 입력해 주세요 : ");
            double radius = double.Parse(Console.ReadLine());

            //2. 로직
            double area = Math.PI * radius * radius;

            //3. 출력
            Console.WriteLine($"넓이는{area:F2}입니다.");

        }
    }
}
