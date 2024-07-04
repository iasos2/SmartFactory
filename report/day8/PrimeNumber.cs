
namespace StringPrint08_7
{
    //소수구하기이이이이ㅣ이이이이이이이

    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 100; i++)
            {

                for (int j = 2; j <= i; j++)
                {
                    if (j == i)

                        Console.Write($" {j}");

                    else if (i % j == 0)

                        break;

                }
            }
        }
    }
}
