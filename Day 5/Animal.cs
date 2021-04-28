using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public abstract class Animal
    {
        private string Name;
        public void SetName(string _name)
        {
            Name = _name;
        }
        public string Getname()
        {
            return Name;
        }
        public abstract void Eat();
    }
        
    public class Dog :Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The Dog is Eating");
        }
    }

    class Customer
    {
        public static void Main()
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter dog name: ");
            string dogname = Console.ReadLine();
            dog.SetName(dogname);
            dog.Getname();
            dog.Eat();
            Console.ReadLine();
        }
    }
}
