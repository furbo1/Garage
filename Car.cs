using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class Car:Vehicle
    {
      
        public Car(string make, string type, string regNo, string color) : base(make, type, regNo, color)
        {
           
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}";

        }
    }
}
