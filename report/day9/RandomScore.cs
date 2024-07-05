

namespace StringPrint09_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //kor, eng, math --- 성적을 Random을 사용하여 받고 평균만 출력해 보세요.
            int[] score = new int[3];
            int total = 0;
            double avg = 0.0;
            for (int i = 0; i < 3; i++)
            {
                score[i] = random.Next(1, 101);
                total += score[i];
            }
            avg = (double)total / score.Length;
            Console.WriteLine($"평균 : {avg}");
        }
    }
}
