
namespace StringPrint09_8
{
    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("이름이 입력되지 않았습니다.");
                }
                else
                {
                    name = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = Console.ReadLine();
            Console.WriteLine(p.Name);
        }
    }
}
