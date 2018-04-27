using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_2
{
    public struct Train
    {
        public string destination;
        public int trainNumber;
        public TimeSpan departureTime;

        public override string ToString()
        {
            return string.Format("\nНомер: "+trainNumber+"\nПункт назначения: "+destination+"\nВремя отправления: "+departureTime);
        }

    }

    class Struct_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите инфрмацию о поездах.\n");
            Train[] trains = new Train[8];
            try
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    Console.Write("Номер поезда: ");
                    trains[i].trainNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Пункт назначения: ");
                    trains[i].destination = Console.ReadLine();
                    Console.Write("Время отправления (чч:мм:сс): ");
                    trains[i].departureTime = TimeSpan.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }

                Array.Sort(trains, (tr1, tr2) => tr1.trainNumber.CompareTo(tr2.trainNumber));

                Console.Write("\nПожалуйста, введите номер поезда, чтобы получить о нём информацию: ");
                int neededTrain = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(trains.Single(x => x.trainNumber == neededTrain).ToString());
            }
            catch (FormatException) { Console.WriteLine("Строка имела неверный формат."); }
            catch (Exception exp) { Console.WriteLine(exp.Message); } 
            Console.ReadKey();
        }
    }
}
