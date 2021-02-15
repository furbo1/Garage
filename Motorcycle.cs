using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class Motorcycle:Vehicle
    {
        public int NumOfWheels
        {
            get {return 2; }
            set {; }
        }

        public Motorcycle(string make, string type, string regNo, string color) : base(make, type, regNo, color)
        {
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} and has only {NumOfWheels} wheels";

        }
    }
}
