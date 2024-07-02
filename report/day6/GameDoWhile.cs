namespace StringPrint06-2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.Write("플레이어의 이름을 설정해 주세요 : ");
            string name = Console.ReadLine();
            Console.WriteLine($"안녕하세요, 용감한 탐험가 {name}!");
            Thread.Sleep(500);
            Console.WriteLine("드디어 떠나는 모험의 첫 걸음을 내딛게 되었군요.\r\n먼 길을 험난한 여정을 앞두고 있지만,\r\n용기와 지혜로 모든 위기를 헤쳐나가길 바랍니다.");
            Thread.Sleep(500);
            do
            {
                Console.WriteLine("[ 메뉴선택 ]");
                Console.WriteLine("1. 낡은 마을 탐험");
                Console.WriteLine("2. 숲 속 오두막 방문");
                Console.WriteLine("3. 게임 종료");
                Console.Write("선택 : ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("낡은 마을 탐험을 선택하셨습니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("플레이어가 낡은 마을에 도착합니다.\r\n마을 주민들과 대화하고, 마을의 비밀을 파헤칠 수 있는 단서를 얻습니다.\r\n마을의 문제를 해결하기 위해 퀘스트를 수행해야 할 수도 있습니다.\r\n퀘스트를 완료하면 보상을 받을 수 있습니다.");
                        Thread.Sleep(500);
                        break;
                    case 2:
                        Console.WriteLine("숲 속 오두막 방문을 선택하셨습니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("플레이어가 숲 속 오두막에 도착합니다.\r\n오두막에는 은둔하는 마법사가 살고 있습니다.\r\n마법사로부터 새로운 기술을 배우거나, 아이템을 구입할 수 있습니다.\r\n마법사는 플레이어의 여정에 중요한 조언을 해줄 수도 있습니다.");
                        Thread.Sleep(500);
                        break;
                    case 3:
                        Console.WriteLine("프로그램 종료.");
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine("잘못 입력 하셨습니다.");
                        Thread.Sleep(500);
                        break;
                }
            } while (choice != 3);
        }
    }
}
