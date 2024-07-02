namespace StringPrint06-3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("[ 메뉴선택 ]");
                Console.WriteLine("1. 1 ~ 100까지 홀수만 출력합니다.");
                Console.WriteLine("2. 알파벳 A ~ Z / a ~ z 까지 출력합니다.");
                Console.WriteLine("3. 12와 18의 최대공약수(GCD)를 구해봅니다.");
                Console.WriteLine("4. 프로그램을 종료합니다.");
                Console.Write("선택 : ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1~100까지 홀수만 출력합니다.");
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i % 2 == 1)
                                Console.Write($"{i} ");
                        }
                        break;
                    case 2:
                        Console.WriteLine("알파벳 A ~ Z / a ~ z 까지 출력합니다.");
                        char[] arr = new char[27];
                        char ch = 'A';
                        char[] arr2 = new char[27];
                        char ch2 = 'a';
                        for (int i = 1; i < arr.Length; i++)
                        {
                            arr[i] = ch++;
                            Console.Write(arr[i]);
                        }
                        Console.Write(" / ");
                        for (int i = 1; i < arr.Length; i++)
                        {
                            arr2[i] = ch2++;
                            Console.Write(arr2[i]);
                        }
                        break;
                    case 3:
                        int a = 0;
                        int b = 0;
                        Console.WriteLine("12와 18의 최대공약수(GCD)를 구해봅니다.");
                        for (int i = 1; i < 19; i++)
                        {
                            if(12 % i == 0 && 18 % i ==0)
                            {
                                if (i > a)
                                    a = i;
                            }
                        }
                        Console.WriteLine($"최대 공약수는 {a}");
                        break;
                    case 4:
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    default:
                        Console.WriteLine("잘못 입력 하셨습니다.");
                        break;
                }
            } while (choice != 4);
        }
    }
}
