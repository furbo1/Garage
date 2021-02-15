using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class Bus:Vehicle
    {
        public int NumOfSeats
        {
            get;
            set;
        }

        public Bus(string make, string type, string regNo, string color, int numOfSeats) : base(make, type, regNo, color)
        {
            NumOfSeats = numOfSeats;
            Length = 1;
        }

        public override string ToString()
        {
            return $"{base.ToString()} and has only {NumOfSeats} seats";

        }
    }
}
