
namespace StringPrint09_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 4, 5, 7, 3, 2, 1, 9, 8 };
            int temp;
            for (int i = list.Length - 1; i > 0; i--)
            {
                for (int k = 0; k < i; k++)
                {
                    if (list[k] > list[k + 1])
                    {
                        temp = list[k];
                        list[k] = list[k + 1];
                        list[k + 1] = temp;
                    }
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
