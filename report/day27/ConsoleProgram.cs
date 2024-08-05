using Oracle.ManagedDataAccess.Client;

namespace adassadasdasdasdasdasdasd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string strConn = "Data Source=(DESCRIPTION=" +
                             "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                             "(HOST=localhost)(PORT=1521)))" +
                             "(CONNECT_DATA=(SERVER=DEDICATED)" +
                             "(SERVICE_NAME=xe)));" +
                             "User Id=scott;Password=tiger;";


            //1. 연결 객체 만들기 - client
            OracleConnection conn = new OracleConnection(strConn);

            //2.데이터베이스 접속을 위한 연결
            conn.Open();

            //3.서버와 함께 신나게 놀기

            //3.1 Query 명령객체 만들기

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "DROP TABLE SnackBar";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE TABLE SnackBar(" +
                              "NNumber NUMBER(20) NOT NULL," +
                              "Number1 NUMBER(20) NOT NULL," +
                              "Spicy VARCHAR2(20) NOT NULL," +
                              "Tteok VARCHAR2(20) NOT NULL," +
                              "Cheese VARCHAR2(50) NOT NULL" +
                          ")";
            cmd.ExecuteNonQuery();
            //
            List<SnackBar> SnackBar = new List<SnackBar>();


            do

            {
                Console.WriteLine("=========================");
                Console.WriteLine("짱짱 맛있는 민지네 떡볶이집");
                Console.WriteLine("=========================");
                Console.WriteLine("1. 떡볶이 추가하기");
                Console.WriteLine("2. 메뉴 목록 보기");
                Console.WriteLine("3. 메뉴 수정");
                Console.WriteLine("4. 메뉴 삭제");
                Console.WriteLine("5. 종료");
                Console.WriteLine("=========================");
                Console.Write("선택 : ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:


                        break; //초기화

                    case 1:
                        Console.WriteLine("1. 떡볶이 추가하기");
                        Console.WriteLine("============================");
                        Console.WriteLine("");
                        Console.WriteLine("============================");

                        Console.Write("주문번호: ");
                        int NNumber = int.Parse(Console.ReadLine());

                        Console.Write("몇 인분: ");
                        int Number = int.Parse(Console.ReadLine());

                        Console.Write("맵기(5단계까지): ");
                        string Spicy = Console.ReadLine();

                        Console.Write("떡 종류(밀떡/쌀떡): ");
                        string Tteok = Console.ReadLine();

                        Console.Write("치즈 추가 유무(O/X): ");
                        string Cheese = Console.ReadLine();

                        cmd.CommandText = $"INSERT INTO SnackBar (NNumber, Number1, Spicy, Tteok, Cheese) VALUES('{NNumber}','{Number}', '{Spicy}', '{Tteok}', '{Cheese}')";
                        Console.WriteLine("============================");

                        cmd.ExecuteNonQuery();
                        break;

                    case 2:
                        Console.WriteLine("2. 메뉴 목록 보기");
                        Console.WriteLine("============================");
                        Console.WriteLine("메뉴 목록");
                        Console.WriteLine("============================");
                        cmd.CommandText = "SELECT * FROM SnackBar";

                        cmd.ExecuteNonQuery();
                        OracleDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            Number = int.Parse(rdr["Number1"].ToString());
                            Spicy = rdr["Spicy"] as string;
                            Tteok = rdr["Tteok"] as string;
                            Cheese = rdr["Cheese"] as string;
                            Console.WriteLine($"{Number} | {Spicy} | {Tteok} | {Cheese} ");
                        }
                        break;

                    case 3:
                        Console.WriteLine("3. 메뉴 수정");
                        Console.WriteLine("============================");

                        Console.Write("수정할 메뉴의 주문번호를 입력하세요: ");

                        int newNNumber = int.Parse(Console.ReadLine());

                        cmd.CommandText = "SELECT * FROM SnackBar WHERE NNumber = :NNumber";
                        cmd.Parameters.Add(new OracleParameter("NNumber", newNNumber));
                        OracleDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())

                        {
                            // 현재 정보 출력

                            Console.WriteLine($"현재 메뉴 정보: ");
                            Console.WriteLine($"주문번호: {reader["NNumber"]}");
                            Console.WriteLine($"인분: {reader["Number1"]}");
                            Console.WriteLine($"맵기(5단계까지): {reader["Spicy"]}");
                            Console.WriteLine($"떡 종류(밀떡/쌀떡): {reader["Tteok"]}");
                            Console.WriteLine($"치즈 추가 유무(O/X): {reader["Cheese"]}");

                            reader.Close();

                            // 수정할 내용 입력 받기
                            Console.WriteLine("============================");
                            Console.WriteLine("새로운 정보 입력");
                            Console.WriteLine("============================");

                            Console.Write("인분: ");
                            string newNumber1 = Console.ReadLine();

                            Console.Write("맵기(5단계까지): ");
                            string newSpicy = Console.ReadLine();

                            Console.Write("떡 종류(밀떡/쌀떡): ");
                            string newTteok = Console.ReadLine();

                            Console.Write("치즈 추가 유무(O/X): ");
                            string newCheese = Console.ReadLine();

                            // 명함 정보 업데이트
                            cmd.CommandText = "UPDATE SnackBar SET Number1 = :Number1, Spicy = :Spicy, Tteok = :Tteok, Cheese = :Cheese WHERE NNumber = :NNumber";
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new OracleParameter("Number1", newNumber1));
                            cmd.Parameters.Add(new OracleParameter("Spicy", newSpicy));
                            cmd.Parameters.Add(new OracleParameter("Tteok", newTteok));
                            cmd.Parameters.Add(new OracleParameter("Cheese", newCheese));
                            cmd.Parameters.Add(new OracleParameter("NNumber", newNNumber));


                            cmd.ExecuteNonQuery();

                            Console.WriteLine("============================");
                            Console.WriteLine($"주문번호가 {newNNumber}인 명함이 수정되었습니다.");
                            Console.WriteLine("============================");
                        }
                        else
                        {
                            Console.WriteLine($"주문번호가 {newNNumber}인 메뉴가 없습니다.");
                            break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("4. 메뉴 삭제");
                        Console.WriteLine("============================");
                        Console.Write("삭제할 주문번호를 입력하세요: ");

                        NNumber = int.Parse(Console.ReadLine());
                        cmd.CommandText = "DELETE FROM SnackBar WHERE NNumber = :NNumber";
                        cmd.Parameters.Add(new OracleParameter("NNumber", NNumber));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear(); // 매개변수 초기화

                        Console.WriteLine($"주문번호가 {NNumber}인 메뉴가 삭제되었습니다.");
                        Console.WriteLine("============================");

                        break;

                    case 5:
                        //종료
                        break;
                }

            }
            while (choice != 5);

            conn.Close();

        }
    }
}
