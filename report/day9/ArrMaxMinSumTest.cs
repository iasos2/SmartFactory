namespace StringPrint09_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                score[i] = random.Next(71, 101);
            }
            Console.WriteLine($"총점 : {score.Sum()}");
            Console.WriteLine($"가장 높은 점수 : {score.Max()}");
            Console.WriteLine($"가장 낮은 점수 : {score.Min()}");
            Console.WriteLine($"평균점수 : {score.Average()}");
        }
    }
}
