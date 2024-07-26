namespace StringPrint22_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\Temp\\abc.txt";
            string content = "안녕하세요 c#";

            File.WriteAllText(path, content);

            Console.WriteLine("파일 작성 성공!");

            //읽기
            string path2 = "c:\\Temp\\ccc.txt";
            try
            {
                string words = File.ReadAllText(path2);
                Console.WriteLine(words);
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일의 이름이 잘못되었습니다.");
            }
        }
    }
}
