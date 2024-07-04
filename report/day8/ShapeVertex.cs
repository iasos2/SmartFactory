using StringPrint08_1;

namespace StringPrint08_1
{ 
    class Shape
{
    public int vertex;  //멤버변수
                        //Default Constructor
    public Shape()
    {
        vertex = 0;
    }
    public void ShowVertex()
    {
        Console.WriteLine(this.vertex);
    }
    public void ShowVertex(string Msg)
    {
        Console.WriteLine(Msg + " " + vertex);
    }
    public void ShowVertex(string Msg, string position, int repeat)
    {
        Console.WriteLine(Msg + " " + vertex + "현재 지역은" + position + "반복횟수는" + repeat);
    }

    public virtual void ShowName()
    {
        Console.WriteLine("도형입니다.");
    }
}
class Triangle : Shape
{
    public Triangle()
    {
        vertex = 3;
    }

    public void ShowName()
    {
        Console.WriteLine("삼각형입니다.");
    }
}
class Circle : Shape
{
    public void ShowName()
    {
        Console.WriteLine("원입니다.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        triangle.ShowVertex();
        triangle.ShowVertex("꼭지점의 개수는 :");
        triangle.ShowVertex("꼭지점의 개수는 :", "안동", 3);
        triangle.ShowName();
        Circle circle = new Circle();
        circle.ShowName();
    }
}
}

