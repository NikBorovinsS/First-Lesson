using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_4
{
     class Struct_4
    {
       static int DayCount(DateTime birth)
        {
            TimeSpan interval;
            DateTime currentDate = DateTime.Now.Date;        
            DateTime nextBday = new DateTime(DateTime.Now.Year, birth.Month, birth.Day);

            if ((nextBday - currentDate).Days <= 0)
            {
                interval = nextBday.AddYears(1) - currentDate;
            }

            else
            {
                interval = nextBday - currentDate;
            }

            return interval.Days;
        }

        static void Main(string[] args)
        {            
            Console.Write("Please, input your date of birth (DD.MM.YYYY or YYYY.MM.DD): ");
            try
            {
                Console.WriteLine(DayCount(DateTime.Parse(Console.ReadLine())) + " day(s) until your next birthday.");
            }
            catch (Exception) { Console.WriteLine("Wrong format of the input string."); }
            Console.ReadKey();

        }
    }
}
