
namespace StringPrint14_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            int num = 0;
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                num = random.Next(1, 100);
                numberList.Add(num);
            }
            numberList.Sort();
            numberList.Reverse();
            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            numberList.Insert(0, -7);
            numberList.Insert(8, -100);
            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
            numberList.Remove(-7);
            Console.WriteLine();

            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
