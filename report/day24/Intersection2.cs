namespace StringPrint24_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);

            List<int> list2 = new List<int>();
            list2.Add(2);
            list2.Add(3);
            list2.Add(5);
            list2.Add(6);

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
