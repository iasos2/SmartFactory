namespace StringPrint03_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("성적을 입력해 주세요 : ");
                int score = Int32.Parse(Console.ReadLine());
                if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("A학점입니다.");
                }
                else if (score >= 80 && score <= 89)
                {
                    Console.WriteLine("B학점입니다.");
                }
                else if (score >= 70 && score <= 79)
                {
                    Console.WriteLine("C학점입니다.");
                }
                else if (score >= 60 && score <= 69)
                {
                    Console.WriteLine("D학점입니다.");
                }
                else
                {
                    Console.WriteLine("F학점입니다.");
                }
            }
        }
    }
}



