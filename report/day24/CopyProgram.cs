using System.Net;

namespace StringPrint24_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //텍스트 파일을 복사하는 프로그램을 만들어 봅시다.
            //예) myCopy.exe abc.txt   cba.txt
            //abc.txt --> Hello World~!

            //args[0] abc.txt

            //args[1] cba.txt

            string add = $@"C:\Temp\{args[0]}";
            string mal = "Hello World~!";
            string copy = $@"C:\Temp\{args[1]}";

            FileStream fs = new FileStream(add, FileMode.Create);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(mal);
            }

            try
            {
                File.Copy(add, copy, true);
                Console.WriteLine("복사 성공");

            }
            catch
            {
                Console.WriteLine("do not");
            }
        }
    }
}
