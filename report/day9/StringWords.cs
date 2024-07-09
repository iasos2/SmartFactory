
namespace StringPrint09_15 //문자열의 개수를 출력해 주세용
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.문자열 입력
            String words = Console.ReadLine();
            //2.변수 카운트변수 4개
            int bigCnt = 0, smallCnt = 0, numberCnt = 0, specialCnt = 0;
            //3.카운팅 로직
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] >= 'A' && words[i] <= 'Z')
                    bigCnt++;
                else if (words[i] >= 'a' && words[i] <= 'z')
                    smallCnt++;
                else if (words[i] >= '0' && words[i] <= '9')
                    numberCnt++;
                else specialCnt++;
            }
            Console.WriteLine($"대문자: {bigCnt}");
            Console.WriteLine($"소문자: {smallCnt}");
            Console.WriteLine($"숫자: {numberCnt}");
            Console.WriteLine($"특수문자: {specialCnt}");
        }

    }
}
