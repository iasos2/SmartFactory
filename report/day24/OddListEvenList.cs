namespace StringPrint24_1
{//정수형 1~100값이 들어있는 리스트 arr를 만드세요. 이를 홀수만 들어있는 arr리스트를
 //이용해서 oddList와 evenList 2개를 만드세요. 리스트는 총 3개
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            for (int i = 0; i < 100 ; i++)
            {
                arr.Add(i+1);
            }
            foreach (int i in arr)
            {
                if (i % 2 != 0) 
                    oddList.Add(i);
                else
                    evenList.Add(i);
            }
            foreach(int i in oddList)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            foreach (int i in evenList)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
