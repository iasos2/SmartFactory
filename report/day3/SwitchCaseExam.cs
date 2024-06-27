namespace StringPrint03_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력을 해주세여.(1.사과 2.배 3.오렌지)... : ");
            int score = Int32.Parse(Console.ReadLine());

            switch (score)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("A학점 입니다.");
                    break;
                case int n when (n >= 80 && n <= 89):
                    Console.WriteLine("B학점 입니다.");
                    break;
                case int n when (n >= 70 && n <= 79):
                    Console.WriteLine("C학점 입니다.");
                    break;
                case int n when (n >= 60 && n <= 69):
                    Console.WriteLine("D학점 입니다.");
                    break;
                default:
                    Console.WriteLine("F학점 입니다.");
                    break;
            }

        }
    }
}



