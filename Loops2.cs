//Author: Borovinskiy Nikita
//Пользователь вводит число вывесли на экран количество разрядов в этом числе

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Loops2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число: ");
            int Number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("В этом числе {0} разрядов\n", Number.ToString().Length);
            Console.ReadKey();
        }
    }
}
