using ElevatorLibrary;
using System;

namespace ElevatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var el = new Elevator();

            el.Name = "1st elevator";

            Console.WriteLine($"{el.Name} is ready.");

            Console.ReadLine();
        }
    }
}
