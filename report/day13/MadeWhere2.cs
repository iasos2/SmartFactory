using System.Runtime.InteropServices;

namespace StringPrint13_5
{
    interface IMaker
    {
        void MadeWhere();
    }
    interface IOwner
    {
        void WhoOwns();
    }
    class Korea : IMaker, IOwner
    {
        public void Korea()
        {
            Console.WriteLine("");
        }
        public void WhoOwns()
        {
            Console.WriteLine("");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IMaker km = new Korea();
            km.MadeWhere();
            //km.WhoOwns();   //안보임
            IOwner ko = new Korea();
            //ko.MadeWher();  //안보임
            ko.WhoOwns();

            object obj = new Korea();
            //obj.MadeWhere();    //Access 불가
            //obj.WhoOwns();  //Access 불가

            Korea korea = new Korea();
            korea.MadeWhere();
            korea.WhoOwns();
        }
    }
}
