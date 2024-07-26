namespace StringPrint22_10
{//할일목록
    internal class Program
    {
        static string[] solution(string[] todo_list, bool[] finished)
        {
            List<string> newWorkList = new List<string>();

            for (int i = 0; i<todo_list.Length; i++)
            {
                if(!finished[i])
                    newWorkList.Add(todo_list[i]);
            }

            return newWorkList.ToArray();//리스트를 배열로 변경하는 메소드
        }
        static void Main(string[] args)
        {
            string[] todo_list = { "DB공부", "운동하기", "밥먹기", "영화보기" };

            bool[] finished = { true, false, true, false };

            string[] list = solution(todo_list, finished);

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }



        }
    }
}
