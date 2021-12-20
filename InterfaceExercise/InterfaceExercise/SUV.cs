using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicles, ICompany
    {
        public bool awd4wd { get; set; }
        public bool nineOrMoreSeats { get; set; }
        public int numWheels { get; set; }
        public bool useGas { get; set; }
        public int numDoor { get; set; }
        public string color { get; set; }
        public string nameOfCompany { get; set; }
        public bool americanMade { get; set; }
    }
}
