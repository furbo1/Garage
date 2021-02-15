using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class Plane : Vehicle
    {
        public int NumOfEngines
        {
            get;
            set;
        }

        public Plane(string make, string type, string regNo, string color , int numOfEngines) : base( make,  type, regNo, color)
        {
            NumOfEngines = numOfEngines;
           Length = 1;
        }

        public override string ToString()
        {
            return $"{base.ToString()} and has only {NumOfEngines} engines";

        }

    }
}
