//Author: Borovinskiy Nikita

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_task_6
{
    class Converter
    {
        private double _USD;
        private double _EUR;
        private double _RUB;

        public Converter(double USD, double EUR, double RUB)
        {
            _USD = USD;
            _EUR = EUR;
            _RUB = RUB; 
        }

        public double USD 
        {
            get
            {
                return _USD;
            }
        }

        public double EUR 
        {
            get
            {
                return _EUR;
            }
        }

        public double RUB
        {
            get
            {
                return _RUB;
            }
        }
    }

    class Classes6
    {
        static void Main(string[] args)
        {
            Converter MyConverter = new Converter(25, 30, 0.4);

            double ratio;

            Console.WriteLine("Если вы хотите конвертировать гривну в другу валюту, нажмите 1\n");
            Console.WriteLine("Если же вы хотите конвертировать иностранную валюту в гривну, нажмите 2");

            char key = Console.ReadKey().KeyChar;

            Console.WriteLine("Введите сумму для конвертации: ");
            int InputValue = Int32.Parse(Console.ReadLine());

            if (key.Equals('1'))
            {
                Console.Clear();
                Console.WriteLine("Нажмите кнопку соответствующую валюте, в которую вы хотите конвертировать.\n");
                Console.WriteLine("1. Доллар\n");
                Console.WriteLine("2. Евро\n");
                Console.WriteLine("3. Рубль\n");

                key = Console.ReadKey().KeyChar;

                switch(key)
                {
                    case '1': ratio = MyConverter.USD;
                        Console.WriteLine("Сумма после конвертации: {0}", InputValue / ratio);
                        break;
                    case '2': ratio = MyConverter.EUR;
                        Console.WriteLine("Сумма после конвертации: {0}", InputValue / ratio);
                        break;
                    case '3': ratio = MyConverter.RUB;
                        Console.WriteLine("Сумма после конвертации: {0}", InputValue / ratio);
                        break;
                }
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Нажмите кнопку соответствующую валюте, которую вы хотите конвертировать в гривну.\n");
                Console.WriteLine("1. Доллар\n");
                Console.WriteLine("2. Евро\n");
                Console.WriteLine("3. Рубль\n");

                key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case '1': ratio = MyConverter.USD;
                        Console.WriteLine("Сумма после конвертации: {0}", InputValue * ratio);
                        break;
                    case '2': ratio = MyConverter.EUR;
                        Console.WriteLine("Сумма после конвертации: {0}", InputValue * ratio);
                        break;
                    case '3': ratio = MyConverter.RUB;
                        Console.WriteLine("Сумма после конвертации: {0}", InputValue * ratio);
                        break;
                }
            }

            Console.ReadKey();

        }
    }
}
