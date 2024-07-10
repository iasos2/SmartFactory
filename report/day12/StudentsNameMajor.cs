
namespace StringPrint12_4
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "아무개";
        public string Major { get; set; } = "공통학부";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[3];
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            student[0] = s1;
            student[1] = s2;
            student[2] = s3;

            s1.Id = 1;
            s1.Name = "홍길동";
            s1.Major = "컴퓨터공학";

            s2.Id = 2;
            s2.Name = "이순신";
            s2.Major = "기계공학";

            s3.Id = 3;
            s3.Name = "강감찬";
            s3.Major = "전자공학";

            foreach (Student s in student)
            {
                Console.WriteLine(s.Id);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Major);
            }

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine(student[i].Id);
                Console.WriteLine(student[i].Name);
                Console.WriteLine(student[i].Major);
            }
        }
    }
}
