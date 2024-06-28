namespace StringPrint03_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int num;

            num = Int32.Parse(Console.ReadLine());

            for (i = 0; i > num; i--)      
            {
                for (j = 0; j < num; j++)   
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
