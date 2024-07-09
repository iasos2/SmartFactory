namespace StringPrint10_2
{
    abstract class Teran
    {
        public abstract void Attack();

    }
    class Marin : Teran
    {
        public override void Attack()
        {
            Console.WriteLine("마린이 공격합니다.");
        }
    }
    class Firebat : Teran
    {
        public override void Attack()
        {
            Console.WriteLine("파이어뱃이 공격합니다.");
        }
    }
    class SiegeTank : Teran
    {
        public override void Attack()
        {
            Console.WriteLine("시저탱크가 공격합니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teran t = new Marin();
            t.Attack();
            Teran f = new Firebat();
            f.Attack();
            Teran s = new SiegeTank();
            s.Attack();
        }
    }
}
