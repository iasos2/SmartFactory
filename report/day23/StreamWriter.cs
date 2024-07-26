namespace StringPrint22_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\Temp\\hello.txt";
            string content = "안녕하세요. 인사파일 입니다";

            StreamWriter writer = new StreamWriter(path);

            using (StreamWriter writer2 = new StreamWriter(path))
            {
                writer.WriteLine(content);
                //writer.Close()
            }
            Console.WriteLine("현재 프로그램이 종료합니다.");
        }
    }
}
