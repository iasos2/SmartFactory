namespace StringPrint08_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수를 도구처럼 사용할 수 있어야 한다!!!!!!!!!!!1
            bool flag = false; //FLAG변수

            for(int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                    Console.Write($"{i} ");
                flag = false;
            }
            Console.WriteLine();
        }
    }
}
