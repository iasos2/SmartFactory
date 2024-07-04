namespace StringPrint08_3
{
    //다중상속
    //유니콘~~~!!!! 날개가 있는 말!!! 

    class Horse
    { 
        public void Run()
        {
            Console.WriteLine("말이 달리고 있습니다.");
        }
    }

    class Angel { }

    interface IWing
    {
        public void Fly();
    }

    interface IWing2
    {
        public void Fly();
    }

    class Unicon : Horse, IWing
    {
        //interface의 메소드 구현
        public void Fly()

        {
            Console.WriteLine("유니콘이 날고 있습니다.");
        }

        //유니콘의 멤버메소드

        public void PerformMagic()
        {
            Console.WriteLine("마법을 사용합니다.");
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Unicon jack = new Unicon();

            jack.Run();
            jack.Fly();
            jack.PerformMagic();
        }
    }
}
