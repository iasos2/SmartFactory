
using System.Runtime.InteropServices;

namespace StrintPrint10_1
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다.");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다.");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Shape s1 = new Triangle();
            s1.Draw();
            Shape s2 = new Circle();
            s2.Draw();
            Circle c = new Circle();
            c.Draw();

            s1 = new Circle();
            s1.Draw();
        }
    }
}
