
namespace StringPrint09_7
{
    class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine("안녕하세요. " + p.Name + " 씨");
        }
    }
}
