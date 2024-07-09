
namespace StringPrint09_10
{
    class User
    {
        private readonly string userID; //상수 처리
        private readonly string userPW; //상수 처리

        public User(string userID, string userPW)
        {
            this.userID = userID;
            this.userPW = userPW;
        }
        public void Print()
        {
            Console.WriteLine(this.userID);
            Console.WriteLine(this.userPW);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string uID = "abc";
            string uPW = "abc";

            User user = new User(uID, uPW);
            user.Print();
        }
    }
}
