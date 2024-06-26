namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력해 주세요 : ");
            int number = Int32.Parse(Console.ReadLine());  //변수 선언과 동시 초기화

            if (number % 2 == 0)    //=if (number % 2 ! =1)
            {
                Console.WriteLine("짝수입니다.", number);
            }
            else
            {
                Console.WriteLine("홀수입니다.", number);


            }
        }
    }
}
