namespace StringPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "홍길동";
            string secondFriend = "크리스티나";

            Console.WriteLine($"나의 친구는 {firstFriend}과 {secondFriend}입니다.");

            Console.WriteLine($"{firstFriend.Length} {secondFriend.Length}");
        }
    }
}
