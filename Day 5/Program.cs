using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        //responsible for generation of obj
        Program()
        {
            Console.WriteLine("Constructor is called");
        }
        //resp for destruction of obj
        //convert back to heap my
        //using finalize method
        ~Program()
        {
            Console.WriteLine("Destructor is called");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Im in main program");
            Program p = new Program();
            Console.ReadLine();
        }
    }
}
