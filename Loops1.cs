//Author: Borovinskiy Nikita
//Вывести на экран таблицу умножения на N от 1 до 20 где N число введенное пользователем

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Loops1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; ++i)
            {
                Console.WriteLine("{0} * {1} = {2}\t", N, i, N*i);
            }
            Console.ReadKey();
        }
    }
}
