

namespace StringPrint22_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            char[] alpaabets = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alpaabets[i] = ch++;
            }
            var result = from c in alpaabets
                         orderby c descending
                         select c;

            foreach (char e in result)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}

