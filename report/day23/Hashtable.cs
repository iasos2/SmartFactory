using System.Collections;

namespace StringPrint22_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["하나"] = "One";
            ht["둘"] = "Tow";
            ht["셋"] = "Three";
            ht["넷"] = "Four";

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
        }
    }
}
