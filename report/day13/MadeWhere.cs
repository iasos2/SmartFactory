
namespace StringPrint13_4
{
    interface IMaker
    {
        void MadeWhere();
        void Warehouse();
    }
    class Korea : IMaker
    {
        public void MadeWhere()
        {
            Console.WriteLine("국산입니다.");
        }

        public void Warehouse()
        {
            Console.WriteLine("상품등록완료");
        }
    }
    class China : IMaker
    {
        public void MadeWhere()
        {
            Console.WriteLine("중국산입니다.");
        }

        public void Warehouse()
        {
            Console.WriteLine("상품등록완료");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
       
            IMaker korea = new Korea();
            korea.MadeWhere();
            korea.Warehouse();

            IMaker china = new China();
            china.MadeWhere();
            china.Warehouse();
        }
    }
}
