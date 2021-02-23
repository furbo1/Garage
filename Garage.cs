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
        private int vehicleCount;
        

        

        public Garage(int toNum)
        {
            parkingLotsInitialCapacity = toNum;
            vehiclesParked = new T[parkingLotsInitialCapacity];
        }

        internal void Add(T vehicle)
        {
            

            if (ParkingLotsAvailable() >= 1)
            {
                for (var i = 0; i < vehiclesParked.Length; i++)
                {
                    if (vehiclesParked[i] == null)
                    {
                        vehiclesParked[i] = vehicle;
                        vehicleCount++;
                       
                        Utils.Print(str: $"Congratulations, you added a car {vehicle.Make}, model {vehicle.Type}, registration number is: {vehicle.RegNo} & color {vehicle.Color} to garage!\n " +
                            $"Number of parking lots available is { ParkingLotsAvailable() }");
                        
                        break;

                    }
                }
                
            }
            else
            {
                Utils.Print("Unfortunately there are no parking lots availble, please return later!");
                
              
            }
           
        }

         public bool SanitizeVehicleInput(Vehicle vehicle)
        {
            if(vehicle == null)
            {
                return false;
            }
            return true;
        }

        public  void DisplayAllVehicles()
        {
          
            for (int i = 0; i < vehiclesParked.Length; i++)
            {
               
                if (!SanitizeVehicleInput(vehiclesParked[0]))
                {

                    Utils.Print("There are no vehicles in the garage.");
                    break;
                   
                }
                else if(!SanitizeVehicleInput(vehiclesParked[i]))
                {
                    break;
                }
                else
                {
                    Utils.Print(str: $"Vehicle {vehiclesParked[i].Make}, model {vehiclesParked[i].Type}, registration number {vehiclesParked[i].RegNo} & color {vehiclesParked[i].Color}!\n ");
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
            return vehicleCount;
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

            return Math.Max(0, (vehiclesParked.Length - vehicleCount));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < vehiclesParked.Length; i++)
            {
                yield return vehiclesParked[i] as T;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}


         
       

