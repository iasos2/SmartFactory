namespace StringPrint15_3
{
    class Car
    {
        public string Brand { get; set; }
        public string Speed { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.브랜드와 스피드 다른 자동차 3개를 만드세요.
            List<Car> carList = new List<Car>();
            //2.car객체를 담는 carList를 만들어요
            Car car1 = new Car();
            car1.Brand = "현대";
            carList.Add(car1);
            car1.Speed = "300km";

            Car car2 = new Car();
            car2.Brand = "기아";
            carList.Add(car2);
            car2.Speed = "280km";

            Car car3 = new Car();
            car3.Brand = "BMW";
            carList.Add(car3);
            car3.Speed = "290km";
            //3.carList를 이용해 자동차의 브랜드와 속도를 출력하세요.
            foreach (Car car in carList)
            {
                Console.WriteLine(car.Brand);
                Console.WriteLine(car.Speed);
                Console.WriteLine();
            }
        }
    }
}
