using System.Security.Authentication;
using System.Text;

namespace StringPrint24_5
{//1 ~ 100사이의 5의 배수를 C:\Temp\result1.txt에 결과를 출력해 보세요.
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\result.txt";
            FileInfo fileInfo = new FileInfo(path);

            List<int> list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if(i % 5 == 0)
                list.Add(i);

            }
            using(StreamWriter sw = fileInfo.CreateText())
            {
                foreach(int number in list)
                {
                    sw.WriteLine(number);
                }
            }
            using (StreamReader sr = fileInfo.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
