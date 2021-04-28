using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public interface Ivehicle
    {
        void Drive();
        bool Refuel(int amnt);
    }
    class Car:Ivehicle
    {
        public int fuel { get; set; }
        public Car(int _fuel)
        {
            fuel = _fuel;
        }
        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("The car is driving");
            }
            else
            {
                Console.WriteLine("No fuel");
            }
            
        }
        public bool Refuel(int amnt)
        {
            fuel += amnt;
            Console.WriteLine("total fuel= " + fuel);
            return true;
        }
    }
    class Customer
    {
        public static void Main()
        {
            Car car = new Car(0);
            Console.WriteLine("Enter the amount of gasoline to refuel: ");
            int fuel = Convert.ToInt32(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
            Console.ReadLine();
        }
    }
}

