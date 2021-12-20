using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicles
    {
        public int numWheels { get; set; }
        public bool useGas { get; set; }
        public int numDoor { get; set; }
        public string color { get; set; }
    }
}
