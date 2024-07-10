namespace StringPrint12_8
{
    class StudentScore
    {
        private double[,] echoScore = new double[3, 3]
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 },
        };
        //매개변수를 두개 가지는 인덱서
        public double this[int x, int y]
        {
            set { echoScore[x, y] = value; }
            get { return echoScore[x, y]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;  //학생 카운터
            int b;  //과목별 점수
            double sum = 0.0;  //총점
            double avg = 0.0;  //평균

            StudentScore ss = new StudentScore();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += ss[i, j];
                }
            }
        }
    }
}
