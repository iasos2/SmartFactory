namespace StringPrint13_9
{
    struct School
    {
        public string schName;
        public string stName;
        public int stGrade;

        public void Print()
        {
            Console.WriteLine("고등학교 입니다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            School sc;
            sc.schName = "레이크사이드 고등학교";
            sc.stGrade = 100;

            Console.WriteLine(sc.schName);
            Console.WriteLine(sc.stGrade);
        }
    }
}
