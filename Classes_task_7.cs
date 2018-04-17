//Author: Borovinskiy Nikita

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_task_7
{
    class Employee
    {
        private string _firstName;
        private string _lastName;

        private int _post;
        private int _experience;
        private int _pay;
        private int _tax;

        public Employee(string firstName = "Walter", string lastName = "White")
        {
            _firstName = firstName;
            _lastName = lastName;

            Random rng = new Random();
            _post = rng.Next(1, 3);
            _experience = rng.Next(1, 35);
        }

        public void CalculatePay()
        {
            _pay = _experience * 1000 / _post;
            _tax = _pay / 20;
        }

        public int GetPay()
        {
            return _pay;
        }
        public int GetTax()
        {
            return _tax;
        }
        public string GetFirstName()
        {
            return _firstName;
        }
        public string GetLastName()
        {
            return _lastName;
        }
        public int GetPost()
        {
            return _post;
        }
    }

    class Classes_task_7
    {
        static void Main(string[] args)
        {
            Employee CoWorker = new Employee();

            CoWorker.CalculatePay();

            Console.WriteLine("Имя: {0}\t Фамилия: {1}\t Должность: {2}\t Оклад: {3}\t Налоговый сбор: {4}\t", CoWorker.GetFirstName(), CoWorker.GetLastName(),
                CoWorker.GetPost(), CoWorker.GetPay(), CoWorker.GetTax());

            Console.ReadKey();
        }
    }
}
