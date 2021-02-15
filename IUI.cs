using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class IUI
    {
        internal interface IGarage<T> : IEnumerable<T>
        {

           
             void AddVehicle(T vehicle);
            void RemoveVehicle(T vehicle);
            void CountVehicles();
            void FindVehicleBy(T props);
        }
    }
}
