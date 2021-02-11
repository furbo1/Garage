using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public interface IVehicle<T>:IEnumerable<T>
    {
        public string IDriveMoveSail(double meters);
        public string Turn(string direction);

      


    }
     abstract class Vehicle : IVehicle
    {
        private string make;
        private string type;
        
        protected readonly string regNo;
        private int numOfEngines;
        private string fuelType;
        private int numOfSeats;
        private double length;
        private bool hasEngine;

        public Vehicle( string make, string type, string regNo, int numOfEngines, string fuelType,int numOfSeats,double length, bool hasEngine)
        {
            Make = make;
            Type = type;
            RegNo = regNo;
            NumOfEngines = numOfEngines;
            FuelType = fuelType;
            NumOfSeats = numOfSeats;
            Lenght = length;
            HasEngine = hasEngine;
        }

        public Vehicle()
        {

        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string RegNo
        {
            get { return regNo; }
            set {; }
        }
        public int NumOfEngines
        {
            get { return numOfEngines; }
            set { numOfEngines = value; }
        }
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public int NumOfSeats
        {
            get { return numOfSeats; }
            set { numOfSeats = value; }
        }

        public double Lenght
        {
            get { return length; }
            set { length= value; }
        }

        public bool HasEngine
        {
            get { return hasEngine; }
            set { hasEngine = value; }
        }


         public string IDriveMoveSail(double meters)
        {
            return $"We drove for {meters}";
        }
        public string Turn(string direction)
        {
            return $"Turn {direction}!";
        }

        public string VehicleStats(string make, string type, string regNo, int numOfEngines, string fuelType, int numOfSeats, double length, bool hasEngine)
        {
            return $"This is a {make} & {type} vehicle \n, registration number: {regNo}\n, " +
                $"number of engines: {numOfEngines}\n, fuel type: {fuelType}\n, number of seats: {numOfSeats}\n," +
                $"length {length}\n," +
                $"has engine: {hasEngine}";

        }

        



    }
}
