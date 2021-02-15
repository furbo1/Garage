using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class Boat: Vehicle
    {
        public int NumOfEngines
        {
            get {return 1; }
            set {; }
        }

        public Boat(string make, string type, string regNo, string color) : base(make, type, regNo, color)
        {
           
            Length = 1;
        }

        public override string ToString()
        {
            return $"{base.ToString()} and has only {NumOfEngines} engines";

        }
    }
}
