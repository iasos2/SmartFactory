
namespace StringPrint22_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("사과");
            que.Enqueue("딸기");
            que.Enqueue("배");
            
            while( que.Count > 0 )
            {
                Console.WriteLine( que.Dequeue() );
            }
        }
    }
}
