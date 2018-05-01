using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_3
{
    static class MyClass
    {
        public static int RandomValue()
        {
            Random rng = new Random();
            return rng.Next(1,100);
        }
    }

    public delegate int MyDelegate();
    public delegate int MidValue(MyDelegate[] mas);

    class Delegates_3
    {
        const int MasLength = 5;

        static void Main(string[] args)
        {
            MyDelegate[] DelegateMas = new MyDelegate[MasLength];
            for (int i = 0; i < MasLength; ++i)
            {
                DelegateMas[i] = new MyDelegate(MyClass.RandomValue);
            }

            MidValue MidValDelegate = delegate(MyDelegate[] MD)
            {
                int temp = 0;
                for (int i = 0; i < MasLength; ++i)
                {
                    temp+=MD[i].Invoke();
                }
                return temp / MasLength;
            };

            int midValue = MidValDelegate(DelegateMas);

            Console.WriteLine("Среднее арифметическое: {0}\n", midValue);
            Console.ReadKey();
        }
    }
}
