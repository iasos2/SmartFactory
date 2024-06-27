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
                case int n when (n > 90 && n <= 100):
                    Console.WriteLine("A학점 입니다.");
                    break;

            }

        }
    }
}



