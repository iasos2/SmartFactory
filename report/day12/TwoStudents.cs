namespace StringPrint12_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[10];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("학생의 이름을 입력하세요 : ");
                studentNames[i] = Console.ReadLine();
            }
            int cnt = 0;
            foreach (string y in studentNames)
            {
                Console.WriteLine(studentNames[cnt++]);
            }
        }
    }
}
