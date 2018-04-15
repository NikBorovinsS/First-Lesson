//Author: Borovinskiy Nikita
//Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12-гранный кубик. Если
//выпадают значения от 1 до 5, пользователь проиграл. Если выпадают значения от 6 до 8,
//пользователь получает свою ставку обратно. Если выпало от 9 до 11, пользователь получает
//двойную ставку, а если выпало 12 - ставку умноженную на 10. После окончания игры покажите
//пользователю, сколько он выиграл.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals8
{
    class Conditionals8
    {
        static void Main(string[] args)
        {
            const int MaxStartCapital = 1000;
            const int MinStartCapital = 100;
            const int MinDice = 1;
            const int MaxDice = 12;

            int Bet, Dice, Difference;
            Difference = 0;

            Random HighRoll = new Random();

            int Capital = HighRoll.Next(MinStartCapital, MaxStartCapital);

            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в лотерею!\nВ вашем кармане лежит {0}$.\nПредлагаем сыграть, чтобы начать введите любую сумму.\nЧтобы выйти введите ноль\n", 
                    Capital);
                Bet = Int32.Parse(Console.ReadLine());

                if (Bet == 0) break;
                if ((Capital - Bet) >= 0)
                {
                    Capital -= Bet;
                }
                else {
                    Console.WriteLine("\nУ вас нет денег на такую ставку!\n");
                }

                Dice = HighRoll.Next(MinDice, MaxDice);
                if (Dice == 12)
                {
                    Capital += Bet * 10;
                    Difference += Bet * 9;

                    Console.WriteLine("\nВам выпало число {0}. Поздраляем, у вас джекпот!.\n", Dice);
                    Console.ReadKey();
                    continue;
                }
                if (Dice >= 9)
                {
                    Capital += Bet*2;
                    Difference += Bet;

                    Console.WriteLine("\nВам выпало число {0}. Вы выиграли неплохую сумму.\n", Dice);
                    Console.ReadKey();
                    continue;
                }
                if (Dice >= 6)
                {
                    Capital += Bet;

                    Console.WriteLine("\nВам выпало число {0}. Вам вернулась ваша ставка. Сыграйте ещё и вам точно повезёт.\n", Dice);
                    Console.ReadKey();
                }
                else {
                    Difference -= Bet;

                    Console.WriteLine("\nВам выпало число {0}. К сожалению, вы проиграли.\n", Dice);
                    Console.ReadKey();
                }
            }

            if (Difference > 0)
            {
                Console.WriteLine("\nВаш общий выигрыш составил {0}$. Приходите ещё.\n\n", Difference);
                Console.ReadKey();
            }
            else
            {
                Difference = Difference - Difference*2;
                Console.WriteLine("\nВы потеряли на игре {0}$. Но не бойтесь в следующий раз фортуна вам улыбнётся.", Difference);
                Console.ReadKey();
            }
            
        }
    }
}
