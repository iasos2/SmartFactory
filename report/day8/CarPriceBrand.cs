
using System.Runtime.InteropServices;

namespace StringPrint08_2
{
    class Car
    {
        public virtual void FuleSize()
        {
            Console.WriteLine("연료통이 없습니다.");
        }
        public void Price(int Price)
        {
            Console.WriteLine($"차량의 가격은 {Price}원 입니다.");
        }
        public void Brand(string Brand)
        {
            Console.WriteLine($"차량의 브랜드는 {Brand} 입니다.");
        }
    }
    class Bus : Car
    {
        public override void FuleSize()
        {
            Console.WriteLine("연료통의 크기는 130L입니다.");
        }
    }
    class Taxi : Car
    {
        public override void FuleSize()
        {
            Console.WriteLine("연료통의 크기는 50L입니다.");
        }
    }
    class Truck : Car
    {
        public override void FuleSize()
        {
            Console.WriteLine("연료통의 크기는 150L입니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bus bus = new Bus();
            Taxi taxi = new Taxi();
            Truck truck = new Truck();
            car.FuleSize();
            bus.FuleSize();
            taxi.FuleSize();
            truck.FuleSize();

            car.Price(100000000);
            car.Brand("벤츠");

        }
    }
}
