using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_3
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    class Struct_3
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }

        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            myStruct.change = "Не изменено";

            MyClass myClass = new MyClass();
            myClass.change = "Не изменено";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("{0}\n", myClass.change);
            Console.WriteLine("{0}\n", myStruct.change);
            Console.ReadKey();
        }
    }
}
