
namespace StringPrint12_10
{
    public class ScoreBoard
    {
        private int[] scores = new int[5];
        
        public int this[int index]
        {
            get { return scores[index]; }
            set { scores[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoreBoard sb = new ScoreBoard();
                sb[0] = 100;
                sb[1] = 90;
                sb[2] = 80;
        }
    }
}
