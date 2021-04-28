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
            System.DateTime datetime = DateTime.Now;
            Console.WriteLine("Todays Date= " + datetime);
            Console.WriteLine("Year= " + datetime.Year);
            Console.WriteLine("Month= " + datetime.Month);
            Console.WriteLine("Day= " + datetime.Day);
            Console.WriteLine("Hour= " + datetime.Hour);
            Console.WriteLine("Minutes = " + datetime.Minute);
            Console.WriteLine("Seconds= " + datetime.Second);
            Console.WriteLine("Millisecond = " + datetime.Millisecond);
            Console.ReadLine();

        }


    }
}
