namespace StringPrint14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];
            {
                chars[0] = 'A';
                chars[1] = 'B';
                chars[2] = 'C';

                List<char> chrList = new List<char>();
                chrList.Add('A');
                chrList.Add('B');
                chrList.Add('C');

                foreach (char c in chars)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
