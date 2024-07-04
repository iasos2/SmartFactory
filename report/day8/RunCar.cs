using System.Runtime.InteropServices;

namespace StringPrint08_4
{
    class Car
    {
        public void Run()
        {
            Console.WriteLine("차량의 시동을 걸었습니다.");
        }
    }
    class Control { }
    interface ISpeed
    {
        public void Speed();
    }
    class Sclass : Car, ISpeed
    {
        public void Speed()
        {
            Console.WriteLine("차량이 달리고 있습니다.");
        }
        public void Direction()
        {
            Console.WriteLine("차량의 방향을 전환합니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sclass sclass = new Sclass();
            sclass.Run();
            sclass.Speed();
            sclass.Direction();
        }
    }
}
