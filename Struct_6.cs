using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_6
{
    class Struct_6
    {
        enum Post { Director = 50, Manager = 40, Driver = 30, Cleaner = 20 };

        class Accountant
        {
            bool AskForBonus(Post worker, int hours)
            {
                return hours > (int)worker;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
