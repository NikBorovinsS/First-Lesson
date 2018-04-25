using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    static class StringExtension
    {
        public static string MySubstring(this string value, int startIndex, int length)
        {
            string result = "";
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += value[i];
            }
            return result;
        }


        public static int MyIndexOf(this string value, string substring)
        {
            if (value.Contains(substring))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == substring.First()) return i;
                }
            }
            return -1;
        }

        public static string MyReplace(this string value, string oldStr, string newStr)
        {
            int index = value.IndexOf(oldStr);
            if (index == -1) return value;
            else
            {
                return value.Remove(index, oldStr.Length).Insert(index, newStr);
            }
        }

    }

     class Static_4
    {
        static void Main(string[] args)
        {
            string txt = "My mom is the most beautiful person in the world.";
            Console.WriteLine("Initial text:\n"+txt);
            Console.WriteLine("\nIndex of \"mom\": "+txt.MyIndexOf("mom"));
            Console.WriteLine("\nReplacement:\n"+txt.MyReplace("mom", "mother"));
            Console.WriteLine("\nSubstring, that starts from index 3 and has length of 3 characters: " + txt.MySubstring(3, 3));
            Console.ReadKey();

        } 
    }
}
