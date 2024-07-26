namespace StringPrint24_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\newjeans.png";
            string copyPic = @"c:\Temp\CopyNewjeans.png";
            try
            {
                byte[] pictureBytes = File.ReadAllBytes(path);

                File.WriteAllBytes(copyPic, pictureBytes);

                Console.WriteLine("복사 성공");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
