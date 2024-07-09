
namespace StrintPrint09_16
{
    class Student
    {
        public string Name { get; set; } = "아무개";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "";
            Console.WriteLine(s.Name);
        }
    }
}
