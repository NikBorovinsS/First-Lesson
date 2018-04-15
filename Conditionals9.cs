//Author: Borovinskiy Nikita
//Сделать программу перевода валют. Вводится сумма, потом выбирается вид валюты – гривны
//или доллары или евро, программа переводит в две другие валюты. Текущий курс валюты
//считать известным.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals9
{
    class Conditionals9
    {
        enum Currency { UAH = 1, USD = 25, EUR = 30 };

        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру соотвествующую валюте, которую вы хотите конвертировать:\n");
            Console.WriteLine("1. Гривня\n");
            Console.WriteLine("2. Доллар\n");
            Console.WriteLine("3. Евро\n");

            char key = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите желаемую сумму для конвертации: ");

            int InputValue = Int32.Parse(Console.ReadLine());

            float ratio;

            switch (key)
            {
                case '1': ratio = (float)Currency.UAH / (float)Currency.USD;
                    Console.WriteLine("\nДоллар: {0}", InputValue*ratio);

                    ratio = (float)Currency.UAH / (float)Currency.EUR;
                    Console.WriteLine("\nЕвро: {0}", InputValue * ratio);
                    Console.ReadKey();
                    break;

                case '2': ratio = (float)Currency.USD / (float)Currency.UAH;
                    Console.WriteLine("\nГривня: {0}", InputValue * ratio);

                    ratio = (float)Currency.USD / (float)Currency.EUR;
                    Console.WriteLine("\nЕвро: {0}", InputValue * ratio);
                    Console.ReadKey();
                    break;

                case '3': ratio = (float)Currency.EUR / (float)Currency.UAH;
                    Console.WriteLine("\nГривня: {0}", InputValue * ratio);

                    ratio = (float)Currency.EUR / (float)Currency.USD;
                    Console.WriteLine("\nДоллар: {0}", InputValue * ratio);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
