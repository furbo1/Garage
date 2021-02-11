using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public interface IGarage<T>: IEnumerable<T>
    {
        public T AddVehicles(object obj);
        public T RemoveVehicles(object obj);

        public T CountVehicles();
        public T FindVehicleBy(T list, T props);
    }
    class Garage<T>: IGarage<T>
    {
        Motorcycle moto = new Motorcycle();
       
    }
}
