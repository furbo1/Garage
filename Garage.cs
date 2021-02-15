using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApp
{

    class Garage<T> : IUI
    {

        private T[] vehiclesParked = null;
        private int parkingLotsInitialCapacity;
        private int lotsCount;
        

        

        public Garage(int toNum)
        {
            parkingLotsInitialCapacity = toNum;
            vehiclesParked = new T[parkingLotsInitialCapacity];
        }

        //public Garage()
        //{

        //}
        public void RemoveVehicle(T vehicle)
        {
           for(var i = 0; i < vehiclesParked.Length; i++)
            {
                if(vehiclesParked[i] != null && vehiclesParked[i].Equals(vehicle))
                {

                    
                    vehiclesParked[i] = null ;
                }
            }

            Utils.Print($"Vehicle Removed.\n Total number of vehicles parked in garage is {vehiclesParked.Length}");

        }

        public  int CountVehicles()
        {
            return vehiclesParked.Length - lotsCount;
        }

        
        public void FindVehicleBy(Vehicle props)
        {
            var upperProps = props.ToString();
            upperProps = upperProps.ToUpper();
            int propsNum;

        }

        

        internal void Add(T vehicle)
        {
            var parkAvailable = ParkingLotsAvailable();
           
            if (parkAvailable > 0)
            {
                for(var i = 0; i < vehiclesParked.Length; i++)
                {
                    if(vehiclesParked[i] == null)
                    {
                        vehiclesParked[i] = vehicle;
                       
                    }
                }
                    lotsCount++;
            }
            else
            {
                Utils.Print("Unfortunately there are no parking lots availble, please return later!");
                Environment.Exit(0);
            }
            ;
        }

        //internal int SumOfVehicleLengths()
        //{
        //    foreach(Vehicle vehicle in vehiclesParked)
        //    {
        //        sumOfVehicleLengths += vehicle.Length;
        //    }

        //    return sumOfVehicleLengths;

        //}

        public int ParkingLotsAvailable()
        {

            return Math.Max(0, (vehiclesParked.Length - lotsCount));
        }

    }

}


         
       

