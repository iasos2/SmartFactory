
using System.Security.Principal;

namespace StringPrint11_9
{
    class BankAccont
    {
        //멤버 ((잔고))
        private double balance = 0;

        //메소드 1.예금하다
        public void Deposit(double money)
        {
            balance += money;
        }
        //메소드 2. 인출하다
        public void WithDraw(double money)
        {
            balance += money;
        }
        //메소드 3. 잔고확인
        public void GetBalance()
        {
            Console.WriteLine($"잔고확인: {balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccont();
            account.Deposit(50000);

            //30000만원 인출
            account.WithDraw(30000);
            //잔고확인
            //20000만원 확인
            account.GetBalance();
        }
    }
}
