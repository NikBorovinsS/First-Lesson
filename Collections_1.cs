using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_1
{
    class Collections_1
    {
        static IEnumerable<int> GetEvenNumbers (int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] % 2 == 0) yield return array[i];
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[] {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("Elements of the array:");
            foreach (int i in myArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nEven numbers in the array: ");
            foreach (int i in GetEvenNumbers(myArray))
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
