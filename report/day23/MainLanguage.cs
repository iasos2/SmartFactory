namespace StringPrint22_15
{
    //p.624
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format($"{0}:{1} int {2}", Name, Age, Address);
        }
    }
    class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person {Name = "Tom", Age = 63, Address = "Korea" },
                new Person {Name = "Winnie", Age = 40, Address = "Tibet" },
                new Person {Name = "Anders", Age = 47, Address = "Sudan" },
                new Person {Name = "Hans", Age = 25, Address = "Tibet" },
                new Person {Name = "Eureka", Age = 32, Address = "Sudan" },
                new Person {Name = "Hawk", Age = 15, Address = "Korea" },
            };
            List<MainLanguage> languages = new List<MainLanguage>
            {
                new MainLanguage {Name = "Anders", Language = "Delphi" },
                new MainLanguage {Name = "Anders", Language = "C#" },
                new MainLanguage {Name = "Tom", Language = "Borland C++" },
                new MainLanguage {Name = "Hans", Language = "Visyal C++" },
                new MainLanguage {Name = "Winnie", Language = "R" }
            };

            //Linq
            var all = from personn in people
                      select personn;

            foreach (var item in all)
            {
                Console.WriteLine($"{item.Name}: {item.Age} in {item.Address}");
                //Console.WriteLine(string.Join(Environment.NewLine, all));
            }
        }
    }
}
