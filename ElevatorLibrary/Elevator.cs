using System;
using System.Collections.Generic;
using System.Text;

namespace ElevatorLibrary
{
    public class Elevator
    {
        const int TopFloor = 10;
        const int BottomFloor = 1;

        public string Name { get; set; }
        public int CurrentFloor { get; set; }
        public ElevatorStatus Status { get; set; }

    }

    public class FloorButton
    {
        public int FloorNo { get; set; }
        public RequestDir Direction { get; set; }
    }

    public class WhichElevator
    {
        public void ChooseElevator(int RequestedFloor, int el1Current, int el2Current, int el3Current)
        {
            int el1Diff;
            int el2Diff;
            int el3Diff;

            el1Diff = RequestedFloor - el1Current;
        
        }
    }


    public enum ElevatorStatus
    {
        MOVING_UP,
        MOVING_DOWN,
        STOPPED
    }

    // Elevator buttons on each floor
    public enum RequestDir
    {
        UP,
        DOWN,
        NOT_PRESSED
    }
}
