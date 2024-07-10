
namespace StringPrint12_7
{
    class IdxDemo
    {
        private int[] num = new int[5];
        public int this[int x]
        {
            set { num[x] = value; }
            get { return num[x]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IdxDemo test = new IdxDemo();
            for (int i = 0; i < 5; i++)
            {
                test[i] = i;
                Console.WriteLine(test[i]);
            }
        }
    }
}
