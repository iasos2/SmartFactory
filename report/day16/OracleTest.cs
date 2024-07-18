namespace OralceTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 외부 프로그램 연결 모듈 받기 --Nuget
            //2. 연결 스크립트를 사용
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=SCOTT;Password=TIGER;";

            //1. 연결 객체 만들기
            OralceConnection conn = new OralceConnection(strConn);

            //2. 연결 객체 만들기
            conn.Open();

            //3. 프로그래밍

            //4. 리소스 반환 및 종료
            conn.Close();
        }
    }
}
