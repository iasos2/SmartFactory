using System;
using System.IO;
namespace StringPrint24_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\abc.txt";
            string content = "Hello World~!";

            //File.WriteAllText(path,content);
            //byte[] bytes = new byte[3] { 1, 2, 3 };
            //File.WriteAllBytes(path,bytes);

            //string str = File.ReadAllText(path);
            //Console.WriteLine(str);

            FileInfo filelnfo = new FileInfo(path);

            StreamWriter sw = filelnfo.CreateText();
            sw.WriteLine("안녕하세요.");

            sw.Close();
        }
    }
}
