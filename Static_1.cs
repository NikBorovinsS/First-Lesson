using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_1
{
    static class Calculator
    {
        static double FirstNum;
        static double SecondNum;

        static Calculator()
        {
            FirstNum = 0;
            SecondNum = 0;
            CalculatorMenu();
        }

        public static void CalculatorMenu()
        {
            int chooser = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(chooser == 0 ? "==>Сложение\n" : "   Сложение\n");
                Console.WriteLine(chooser == 1 ? "==>Вычитание\n" : "   Вычитание\n");
                Console.WriteLine(chooser == 2 ? "==>Умножение\n" : "   Умножение\n");
                Console.WriteLine(chooser == 3 ? "==>Деление\n" : "   Деление\n");
                Console.WriteLine(chooser == 4 ? "==>Синус\n" : "   Синус\n");
                Console.WriteLine(chooser == 5 ? "==>Косинус\n" : "   Косинус\n");
                Console.WriteLine(chooser == 6 ? "==>Тангенс\n" : "   Тангенс\n");
                Console.WriteLine(chooser == 7 ? "==>Квадратный корень\n" : "   Квадратный корень\n");
                Console.WriteLine(chooser == 8 ? "==>Выход\n" : "   Выход\n");
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();

                    switch (chooser)
                    {
                        case 0: Console.WriteLine("Введите первое число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            SecondNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Сумма: {0}", Addition(FirstNum, SecondNum));
                            break;
                        case 1: Console.WriteLine("Введите первое число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            SecondNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Разница: {0}", Substraction(FirstNum, SecondNum));
                            break;
                        case 2: Console.WriteLine("Введите первое число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            SecondNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Произведение: {0}", Multiplication(FirstNum, SecondNum));
                            break;
                        case 3: Console.WriteLine("Введите первое число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            SecondNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Частное: {0}", Division(FirstNum, SecondNum));
                            break;
                        case 4: Console.WriteLine("Введите число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Синус: {0}", Sin(FirstNum));
                            break;
                        case 5: Console.WriteLine("Введите число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Косинус: {0}", Cos(FirstNum));
                            break;
                        case 6: Console.WriteLine("Введите число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Тангенс: {0}", Tan(FirstNum));
                            break;
                        case 7: Console.WriteLine("Введите число: ");
                            FirstNum = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Квадратный корень: {0}", SQRT(FirstNum));
                            break;
                        case 8: return;
                    }

                    Console.ReadKey();
                }
                else
                {
                    switch (key)
                    {
                        case ConsoleKey.DownArrow: ++chooser;
                            break;
                        case ConsoleKey.UpArrow: --chooser;
                            break;
                    }
                }
                if (chooser >= 9) chooser = 0;
                if (chooser < 0) chooser = 2;
            }
        }

        static double Addition(double First, double Second)
        {
            return First + Second;
        }

        static double Substraction(double First, double Second)
        {
            return First - Second;
        }

        static double Multiplication(double First, double Second)
        {
            return First * Second;
        }

        static double Division(double First, double Second)
        {
            return First / Second;
        }

        static double Sin(double value)
        {
            return Math.Asin(value);
        }

        static double Cos(double value)
        {
            return Math.Acos(value);
        }

        static double Tan(double value)
        {
            return Math.Atan(value);
        }

        static double SQRT(double value)
        {
            return Math.Sqrt(value);
        }
    }

    class Static_1
    {
        static void Main(string[] args)
        {
            Calculator.CalculatorMenu();
        }
    }
}
