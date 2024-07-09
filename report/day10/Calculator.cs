
namespace StirngPrint10_4
{
    class Calculator
    {
        //멤버변수
        private double radius;
        private double pi = Math.PI;
        private int width, height;
        //생성자

        //멤버메소드

        public double computetrianglearea(int width, int height)
        //public void ComputetriangleArea(int width, int height)
        {
            //return width * height / 2.0;
            width = -width;
            height = -height;

            double result = width * height / 2.0;
            return result;
        }
        public double ComputerCircleArea(int radius)
        {
            this.radius = radius;
            double result = radius * radius * pi;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //계산기를 꺼내서 삼각형의 넓이를 구하고 싶어
            Calculator cal = new Calculator();
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            //cal.ComputetriangleArea(value1, value2);
            double result = cal.computetrianglearea(value1, value2);
            Console.WriteLine(result);

            //계산기를 꺼내서 원의 넓이를 구해봅시다.
            int radius = int.Parse(Console.ReadLine());
            //cal.ComputerCircleArea(radius);
            result = cal.ComputerCircleArea(radius);
            Console.WriteLine(result);
        }
    }
}
