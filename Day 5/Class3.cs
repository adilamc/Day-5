using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Class3
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 5, 8, 10, 76, 86, 97, 66 };
            Array.Sort(arr);
            Console.WriteLine(arr[(arr.Length - 2)]);
            Console.ReadLine();
        }
    }
}
