//Author
//Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на
//само себя.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Lesson
{
    class Conditionals7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");
            int natural=Int32.Parse(Console.ReadLine());

            for (int i = 2; i < natural; ++i)
            {
                if (natural % i == 0)
                {
                    Console.WriteLine("\nЧисло не является простым\n");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("\nЧисло является простым\n");

            Console.ReadKey();
        }
    }
}
