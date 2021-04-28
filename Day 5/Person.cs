using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Person
    {
        public string Name { get; set; }
        public Person(string _name)
        {
            Name = _name;
        }
        public override string ToString()
        {
            return "My name is " + Name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
    }
    class Customer
    {
        public static void Main()
        {
            int total = 3;
            Person[] person = new Person[total];
            for (int i=0; i<total;i++)
            {
                Console.WriteLine("Enter your name:");
                person[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(person[i].ToString());
            }
            Console.ReadLine();
            
        }
        

    }
}
