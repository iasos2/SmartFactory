//Getter Setter
using System.Runtime.InteropServices;

namespace StringPrint13_2
{
    class Product
    {
        private string name;
        private int price;
        private int stock;

        public Product(string name, int price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return this.name;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
