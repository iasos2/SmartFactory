namespace StringPrint09_9
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("디폴트 생성자 호출");
        }
        ~Person()
        {
            Console.WriteLine("소멸자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
        }
    }
}
