namespace StringPrint09_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr4 = new int[5] { 21, 98, 43, 27, 13 };
            int[] arr5 = { 21, 98, 43, 27, 13 };

            Console.WriteLine($"MAX : {arr4.Max()}");
            Console.WriteLine($"MAX : {arr4.Min()}");
            Console.WriteLine($"MAX : {arr4.Sum()}");
            Console.WriteLine($"MAX : {arr4.Average()}");
            Console.WriteLine($"MAX : {arr4.Count()}");
        }
    }
}
