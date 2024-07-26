using System.Text;

namespace StringPrint24_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\test.log";
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine("Hello World");
                    sw.WriteLine("Anderson");
                    sw.WriteLine(32000);
                }

            }
        }
    }
}
