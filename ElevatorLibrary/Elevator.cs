using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorLibrary
{
    public class Elevator
    {
        const int TopFloor = 10;

        public string Name { get; set; }
        public int FloorNo { get; set; }

    }

    public class FloorButton
    {
        public int FloorNo { get; set; }
        public ElevatorDir Direction { get; set; }

    }

    public enum ElevatorDir
    {
        UP,
        DOWN
    }
}
