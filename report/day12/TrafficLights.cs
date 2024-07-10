
namespace StringPrint12_13
{
    enum TrafficLights { Green, Red, Yellow }
    internal class Program
    {
        static void Main(string[] args)
        {
            //주소를 통한 접근
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((TrafficLights)i);
            }
            //인스턴스(객체)를 통한 접근
            TrafficLights r = TrafficLights.Red;
            TrafficLights g = TrafficLights.Green;
            TrafficLights y = TrafficLights.Yellow;
            Console.WriteLine(r);
            Console.WriteLine(g);
            Console.WriteLine(y);
        }
    }
}
