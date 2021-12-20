using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicles, ICompany
    {
        public string trunkSize { get; set; }
        public bool hasSpoiler { get; set; }
        public int numWheels { get; set; }
        public bool useGas { get; set; }
        public int numDoor { get; set; }
        public string color { get; set; }
        public string nameOfCompany { get; set; }
        public bool americanMade { get; set; }
    }
}
