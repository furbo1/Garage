using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    public interface IVehicle 
    {
        public string IDriveMoveSail(double meters);
        public string Turn(string direction);




    }
      class Vehicle : IVehicle
    {
        private string make;
        private string type;
        
        protected readonly string regNo;
        private string color;
        private string fuelType;
        private int numOfSeats;
        private int length;
        private bool hasEngine;
       
        public Vehicle( string make, string type, string regNo, string color )
        {
            Make = make.ToUpper();
            Type = type.ToUpper();
            RegNo = regNo.ToUpper();
            Color = color.ToUpper();
            //FuelType = fuelType.ToUpper();
            Length= 1;
            HasEngine = hasEngine;
        }
        //var vehicle = new Vehicle("", "", "", "");

        public string Make
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string RegNo
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public string FuelType
        {
            get;
            set;
        }

        public int Length { get; set; }

        public bool HasEngine
        {
            get;
            set;
        }


         public string IDriveMoveSail(double meters)
        {
            return $"We drove for {meters}";
        }
        public string Turn(string direction)
        {
            return $"Turn {direction}!";
        }

        //public override string ToString()
        //{
        //    return $"This is a {make} & {type} vehicle \n, registration number: {regNo}\n, " +
        //        $"fuel type: {fuelType}\n, number of seats: {numOfSeats}\n," +
        //        $"length {length}\n," +
        //        $"has engine: {hasEngine}";

        //}


       

        
    }
}
