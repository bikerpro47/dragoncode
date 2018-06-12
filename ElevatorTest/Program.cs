using ElevatorLibrary;
using System;

namespace ElevatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 elevators
            var el1 = new Elevator
            {
                Name = "Elevator No 1",
                CurrentFloor = 1
            };
            var el2 = new Elevator
            {
                Name = "Elevator No 2",
                CurrentFloor = 5
            };
            var el3 = new Elevator
            {
                Name = "Elevator No 3",
                CurrentFloor = 10
            };

            // Create elevator buttons on some floors
            var fb1 = new FloorButton { FloorNo = 1, Direction = RequestDir.NOT_PRESSED };
            var fb2 = new FloorButton { FloorNo = 2, Direction = RequestDir.NOT_PRESSED };
            var fb7 = new FloorButton { FloorNo = 7, Direction = RequestDir.NOT_PRESSED };
            var fb9 = new FloorButton { FloorNo = 9, Direction = RequestDir.NOT_PRESSED };

            // People press some buttons to summon an elevator
            WhichElevator.
            fb1.Direction = RequestDir.UP;
            fb9.Direction = RequestDir.DOWN;
            fb2.Direction = RequestDir.DOWN;
            fb7.Direction = RequestDir.UP;


            Console.WriteLine($"{el1.Name} is on Floor Number {el1.CurrentFloor}");

            Console.ReadLine();
        }
    }
}
