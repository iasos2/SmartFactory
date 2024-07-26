using System.Linq.Expressions;

namespace StrigPrint22_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            try
            {
                int result = a / b;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("0으로 나누는 예외가 발생하였습니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외가 발생하였습니다.");
            }
            finally
            {
                Console.WriteLine("무조건 실행되는 구문");
            }

        }
    }
}
