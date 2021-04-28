using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{

    class Day
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2021, 5, 28, 03, 25, 05);
            Console.WriteLine(String.Format("{0:ddd,MMM d , yyyy}",dt));
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(String.Format("{0:MMM}", dt));
            Console.ReadLine();

        }


    }
}
