
namespace StringPrint14_2
{
    class Call
    {
        public string Pol()
        {
            return "경찰서에 신고하다.";
        }
        public string Fir()
        {
            return "소방서에 신고하다.";
        }

        public string Tax()
        {
            return "국세청에 신고하다.";
        }
    }
    internal class Program
    {
        delegate string Help();
        static void Main(string[] args)
        {
            Call call = new Call();
            Help help = call.Pol;
            Console.WriteLine(help());
            help = call.Fir;
            Console.WriteLine(help());
            help = call.Tax;
            Console.WriteLine(help());
        }
    }
}
