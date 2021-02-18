using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageApp
{

    class Garage<T> :IEnumerable<T> where T : Vehicle
    {

        private T[] vehiclesParked = null;
        private int parkingLotsInitialCapacity;
        private int lotsCount;
        

        

        public Garage(int toNum)
        {
            parkingLotsInitialCapacity = toNum;
            vehiclesParked = new T[parkingLotsInitialCapacity];
        }

        internal void Add(T vehicle)
        {
            var parkAvailable = ParkingLotsAvailable();

            if (parkAvailable > 0)
            {
                for (var i = 0; i < vehiclesParked.Length; i++)
                {
                    if (vehiclesParked[i] == null)
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
           
        }

         public bool SanitizeVehicleInput(T vehicle)
        {
            if(vehicle == null)
            {
                return false;
            }
            return true;
        }

        public void DisplayAllVehicles()
        {
            Vehicle vehicle = null;
            for(int i = 0; i< vehiclesParked.Length; i++)
            {
                vehicle = vehiclesParked[i];
                if(SanitizeVehicleInput(vehicle))
                {
                    Utils.Print($"This is a {vehicle.Make} & {vehicle.Type} vehicle \n, registration number: {vehicle.RegNo}\n, " +
                $"fuel type: {vehicle.FuelType}\n, number of seats: {vehicle.NumOfSeats}\n," +
                $"length {vehicle.Length}\n," );
                }
                else
                {
                    Utils.Print("There are no vehicles in the garage.");
                }
                
                    


           }

    }
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < CountVehicles(); i++)
            {
                yield return vehiclesParked[i] as T;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}


         
       

