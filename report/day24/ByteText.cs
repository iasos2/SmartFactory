namespace StringPrint24_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine($"{someValue :X16}");

            string path = @"C:\Temp\a.dat";
            Stream outStream = new FileStream(path, FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);


            //화면에 byte 출력??
            foreach( byte b in wBytes )
            {
                Console.Write($"{b:X16} ");
            }
            Console.WriteLine();


            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            //읽기 --> binary =>Text 화면에 출력
            Stream inStream = new FileStream(path, FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;

            while (inStream.Position < inStream.Length)
            {
                rbytes[i++] = (byte)inStream.ReadByte();
            }

            long readValue = BitConverter.ToInt64(rbytes, 0);
            Console.WriteLine($"{readValue:X16}");
        }
    }
}
