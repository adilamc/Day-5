using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
   
    class substring
    {
        public static void findallsubstrings(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder stringBuilder = new StringBuilder(str.Length - i);
                for (int j = 0; j < str.Length; j++)
                {
                    stringBuilder.Append(str[j]);
                    Console.Write(stringBuilder + " ");
                }
            }
        }
        public static void Main()
        {
            substring.findallsubstrings("abcd");
            Console.ReadLine();
        }
    }
}
