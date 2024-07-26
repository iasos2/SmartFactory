namespace StringPrint24_2
{//두 리스트의 교집합을 구하세요.
 // list1 --> (1,2,2,3,4) list2 --> (2,3,5,6)
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 2, 3, 4 };
            List<int> list2 = new List<int>() { 2, 3, 5, 6 };
            List<int> list3 = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j] && !(list3.Contains(list1[i])))
                    {
                        list3.Add(list2[j]);
                        Console.WriteLine(list2[j]);

                        break;
                    }
                }
            }
        }

    }
}
