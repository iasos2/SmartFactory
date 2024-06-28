namespace StringPrint04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrint = new int[5];

            for (int i = 0; i < arrint.Length; i++)
            {
                arrint[i] = (i + 1) * 10;
            }

            for (int i = 0; i < arrint.Length; i++)
            {
                Console.WriteLine(arrint[i]);
            }




        }
    }
}
