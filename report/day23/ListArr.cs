using System.Collections;

namespace StringPrint22_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            ArrayList alist = new ArrayList();
            alist.Add('A');
            alist.Add('B');
            alist.Add('C');
            alist.Add(70);


            alist.Insert(2, 'E');
            alist.RemoveAt(0);
            foreach (char ch in alist)
            {
                Console.WriteLine(ch);
            }

            ArrayList blist = new ArrayList();
            blist.Add(1);
            blist.Add('Z');
            Console.WriteLine((int)blist[0]);
            Console.WriteLine((char)blist[1]);
        }
    }
}
