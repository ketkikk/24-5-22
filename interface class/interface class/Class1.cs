using System;
using System.Collections.Generic;
using System.Text;

namespace interface_class
{
    class Class1
    {
        public interface IVehicle
        {
            void Drive();
            bool Refuel(int amount);
        }
        public class Car : IVehicle
        {
            public int Fuel { get; set; }

            public Car(int fuel)
            {
                Fuel = fuel;
            }

            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("Driving");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }

            public bool Refuel(int amount)
            {
                Fuel += amount;
                return true;
            }
        }
        public static void Main(string[] args)
        {
            Car car = new Car(0);

            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}