namespace StringPrint12_14
{
    enum TrafficLights { Green = 1, Red = 10, Yellow = 100 }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            switch ((TrafficLights)x)
            {
                case TrafficLights.Green:
                    break;
                case TrafficLights.Red:
                    break;
                case TrafficLights.Yellow:
                    break;
            }
        }
    }
}
