
namespace StringPrint12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13의 배수가 7개 들어있는 numbers라는 배열을 만드세요
            //값은 for문을 사용하여 채워 넣으세요. 넣은 값을 모두 출력하세요 13..26..

            //1.변수선언
            int[] numbers = new int[7];
            numbers[0] = 1;

            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = 13 * (i + 1);
            }
            for (int i = 0;i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //이름을 3개를 입력하여 string배열 names에 입력해보세요
            //입력배열을 출력하세요
            string[] names = new string[3];
            for (int j = 0; j < names.Length; j++)
            {
                names[j] = Console.ReadLine();
            }
            for (int k = 0; k < names.Length; k++)
            {
                Console.WriteLine(names[k]);
            }

        }

    }

}
