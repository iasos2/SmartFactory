
namespace StringPrint12_12
{
    class MemberInfo
    {
        private string[] names = new string[5];
        public string this[int index]
        {
            set { names[index] = value; }
            get { return names[index]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberInfo mInfo = new MemberInfo();
            mInfo[0] = "홍길동";
            mInfo[1] = "이순신";

            Console.WriteLine(mInfo[0]);
            Console.WriteLine(mInfo[1]);
        }
    }
}
