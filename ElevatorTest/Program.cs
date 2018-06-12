using ElevatorLibrary;
using System;

namespace ElevatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var el1 = new Elevator
            {
                Name = "Elevator No 1",
                FloorNo = 1
            };

            var fb1 = new FloorButton { FloorNo = 1 };
            var fb2 = new FloorButton { FloorNo = 2 };

            // People press some buttons
            fb1.Direction = ElevatorDir.UP;
            fb2.Direction = ElevatorDir.DOWN;


            Console.WriteLine($"{el1.Name} is on Floor Number {el1.FloorNo}");

            Console.ReadLine();
        }
    }
}
