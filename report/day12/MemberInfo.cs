
namespace StringPrint12_9
{
    class MemberInfo
    {
        //private string[] names = new string[5];
        private string name;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberInfo[] mInfo = new MemberInfo[3];
            MemberInfo m1 = new MemberInfo();
            m1.SetName("홍길동");
            mInfo[0] = m1;
            Console.WriteLine(mInfo[0].GetName());

            //mInfo[0] = "홍길동";
            //mInfo[1] = "이순신";
        }
    }
}
