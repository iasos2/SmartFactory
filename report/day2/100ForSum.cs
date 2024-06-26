namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ~ 100까지 합을 구해보세요 for 문으로 (결과 : 5050)
            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                sum += i + 1;
                Console.WriteLine(i + 1);
            }

            Console.WriteLine(sum);
        }
    }
}
