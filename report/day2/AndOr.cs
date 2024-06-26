namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 4;
            if ((a + b + c > 10) && (a == b))   //&&(그리고), ||(or)
            {
                Console.WriteLine("두 조건이 모두 맞았다.");
            }
            else
            {
                Console.WriteLine("두 조건이 모두 맞지 않았다.");
            }

        }
    }
}
