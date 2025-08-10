using System;

namespace Interface
{
    // Interface demo
    interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving
        }
    }
}
