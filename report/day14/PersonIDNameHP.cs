namespace StringPrint14_8
{
    class Person
    {
        public Person() { }
        //ID
        public int ID { get; set; }
        //Name
        public string Name { get; set; }
        //HP
        public string HP { get; set; }

        public Person(int id, string name, string hp)
        {
            ID = id;
            Name = name;
            HP = hp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> addressbook = new List<Person>();
            int choice = 0;
            do
            {
                Console.WriteLine("1. 데이터 삽입");
                Console.WriteLine("2. 데이터 삭제");
                Console.WriteLine("3. 데이터 조회");
                Console.WriteLine("4. 데이터 수정");
                Console.WriteLine("5. 프로그램 종료");
                Console.WriteLine();
                Console.Write("메뉴 : ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("데이터 삽입");
                        Console.Write("ID 번호 : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("이름 : ");
                        string name = Console.ReadLine();
                        Console.Write("전화번호 : ");
                        string hp = Console.ReadLine();
                        Person person = new Person(id, name, hp);
                        addressbook.Add(person);
                        break;
                    case 2:
                        Console.WriteLine("데이터 삭제");
                        break;
                    case 3:
                        Console.WriteLine("데이터 조회");
                        foreach (Person p in addressbook)
                        {
                            Console.WriteLine($"ID : {p.ID}");
                            Console.WriteLine($"Name : {p.Name}");
                            Console.WriteLine($"HP : {p.HP}");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("데이터 수정");
                        break;
                    case 5:
                        Console.WriteLine("프로그램 종료");
                        break;
                    default:
                        Console.WriteLine("잘못 입력 하셨습니다.");
                        break;
                }
            } while (choice != 5);

        }
    }


