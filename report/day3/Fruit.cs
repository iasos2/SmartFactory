namespace StringPrint03_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력을 해주세여.(1.사과 2.배 3.오렌지)... : ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("사과 입니다.");
                    break;
                case 2:
                    Console.WriteLine("배 입니다.");
                    break;
                case 3:
                    Console.WriteLine("오렌지 입니다.");
                    break;
                default:
                    Console.WriteLine("메뉴가 없습니다.");
                    break;
            }

        }
    }
}



