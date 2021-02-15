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
      class Vehicle : IVehicle, IEnumerable
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

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }

        public int Length { get; set; }

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

        public override string ToString()
        {
            return $"This is a {make} & {type} vehicle \n, registration number: {regNo}\n, " +
                $"fuel type: {fuelType}\n, number of seats: {numOfSeats}\n," +
                $"length {length}\n," +
                $"has engine: {hasEngine}";

        }


        public IEnumerator GetEnumerator()
        {
            var vehicle = new Vehicle("", "", "", "");

            foreach (var props in vehicle)
            {
                if (props != null)
                    yield return props;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}
