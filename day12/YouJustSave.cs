
namespace StringPrint12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentIDs = new int[5] {1,2,3,4,5}; //변수선언 및 초기화
            //studentIDs[0] = 1; 선언 후 초기화

            string[] studentNames = new string[3] { "James", "Tom", "Jimmy" };

            int[] evenNums = new int[10];

            for (int x = 0; x < 10; x++)
            {
                evenNums[x] = x + 2;

                Console.WriteLine($"You just saved {evenNums[x]}");
            }
        }
    }
}
