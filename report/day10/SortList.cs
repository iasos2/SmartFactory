
namespace StringPrint10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> data = new HashSet<int>() { 5, 1, 3, 4, 2 };

            //익숙한 배열 ---> List(리스트)로 변경하자
            List<int> myList = new List<int>(data);
            myList.Sort();

            foreach (int i in myList)
            {
                Console.Write(i + " ");
            }
        }
    }
}
