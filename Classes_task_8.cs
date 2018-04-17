//Author: Borovinskiy Nikita

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_task_8
{
    class Invoice
    {
        private const double VATmodifyer = 1.2;

        private string _article;
        private int _quantity;

        private int _account;
        private string _customer;
        private string _provider;

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;

            Article = "Керамическая ваза";
            Quantity = 3750;
        }

        public double CalculateWithVAT()
        {
            double FullPrice = (double)Quantity * VATmodifyer;
            return FullPrice;
        }
        public int CalculateWithoutVAT()
        {
            return Quantity;
        }

        public string Article
        {
            get
            {
                return _article;
            }
            set
            {
                _article = value;
            }
        }

        public int Quantity
        {
            get 
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
    }

    class Classes_task_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя клиента: ");
            string Customer = Console.ReadLine();

            Console.WriteLine("\nВведите кол-во денег на счету: ");
            int Account =Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите имя поставщика: ");
            string Provider = Console.ReadLine();

            Invoice MyInvoice = new Invoice(Account, Customer, Provider);

            Console.Clear();
            Console.WriteLine("Вывести сумму покупки с учётом НДС?");
            Console.WriteLine("\n1. Да");
            Console.WriteLine("\n2. Нет\n");

            char key = Console.ReadKey().KeyChar;

            if (key.Equals('1'))
            {
                Console.WriteLine("Цена покупки {0} с учётом НДС: {1}", MyInvoice.Article , MyInvoice.CalculateWithVAT());
            }
            else 
            {
                Console.WriteLine("Цена покупки {0} без НДС: {1}", MyInvoice.Article, MyInvoice.CalculateWithoutVAT());
            }

            Console.ReadKey();
        }
    }
}
