namespace StringPrint14_9
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
                        Console.Write("삭제할 데이터의 ID를 입력해 주세요 : ");
                        int locate = int.Parse(Console.ReadLine());
                        for (int i = 0; i < addressbook.Count; i++)
                        {
                            if (addressbook[i].ID == locate)
                            {
                                addressbook.RemoveAt(i);
                            }
                        }
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
                        Console.Write("수정할 위치 : ");
                        int fix = int.Parse(Console.ReadLine());
                        for (int i = 0; i < addressbook.Count; i++)
                        {
                            if (addressbook[i].ID == fix)
                            {
                                addressbook.RemoveAt(fix);
                                Console.Write("수정 ID 번호 : ");
                                int fixid = int.Parse(Console.ReadLine());
                                Console.Write("수정 이름 : ");
                                string fixname = Console.ReadLine();
                                Console.Write("수정 전화번호 : ");
                                string fixhp = Console.ReadLine();
                                person = new Person(fixid, fixname, fixhp);
                                addressbook.Insert(fix, person);
                            }
                        }
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
}
