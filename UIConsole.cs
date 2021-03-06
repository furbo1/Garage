﻿using System;
using System.Collections.Generic;
using System.Text;


namespace GarageApp
{
    public class UIConsole 
    {
        public int toNum;
        Garage<Vehicle> garage;
       
       public void SecondMenu()
        {
            do
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n( 1, 2 ,3, 4, 0) of your choice"
                       + "\n1. Display all the vehicles in the garage"
                       + "\n2. Add vehicles to garage"
                       + "\n3. Remove vehicles from garage"
                       + "\n4. Search vehicles in garage"
                       + "\n0. Exit the application");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Utils.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                }
                switch (input)
                {
                    case '1':
                        garage.DisplayAllVehicles();
                        Utils.Print(str: $"There are {garage.ParkingLotsAvailable()} parking lots available.");
                        break;
                    case '2':
                        Console.Clear();
                        Utils.Print("Please follow the below instructions to add vehicles to garage");
                        AddVehicleMenu();
                        break;
                    case '3':
                        Console.Clear();
                        Utils.Print("Please enter the registration number below to remove the vehicle:");
                        var usrInput = Console.ReadLine();
                        Vehicle v = null;
                        if (!Utils.CheckForInput(usrInput))
                        {
                            garage.RemoveVehicleByRegNumber(usrInput);
                        }
                        else
                        {
                            SecondMenu();
                        }
                        break;
                    case '4':
                        Console.Clear();
                        Utils.Print("Please enter the registration number below:");
                        var usrInp = Console.ReadLine();
                        
                        if(!Utils.CheckForInput(usrInp))
                        {
                            garage.FindVehicleByRegNo(usrInp);
                        }
                        else
                        {
                            SecondMenu();
                        }
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (1 ,2 ,3 , 4, 0)");
                        break;
                }
            } while (true);
        }
        public void Menu()
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(0 , 1) of your choice"
                   + "\n1. Instatiate a new garage with the desired number of parking lots"
                   + "\n0. Exit the application");
            do
            {
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Utils.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();                 
                }
                switch (input)
                {
                    case '1':
                        Utils.Print("Enter the number of parking lots to create a garage.");

                        var userInput = Utils.ReadLine();
                        int value;
                        if (String.IsNullOrEmpty(userInput))
                        {
                            Utils.Print("Enter the number of parking lots to create a garage.");
                            break;
                        }
                        else if (!int.TryParse(userInput, out value))
                        {
                            Utils.Print("Enter the number of parking lots to create a garage.");
                            break;
                        }
                        else
                        {
                            garage = new Garage<Vehicle>(Int32.Parse(userInput));
                            Utils.Print(str: $"Congratulations, you created a garage with { garage.ParkingLotsAvailable()} parking lots");
                            SecondMenu();
                            break;
                        }
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0 , 1)");
                        break;
                }
            } while (true);
        }

        public void AddVehicleMenu()
        {
            char input = ' '; //Creates the character input to be used with the switch-case below.
            while (garage.ParkingLotsAvailable() > 0)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 , 4, 5, 6, 0) of your choice"
                   + "\n1. Press 1 to add a Car"
                   + "\n2. Press 2 to add a Boat"
                   + "\n3. Press 3 to add a Plane"
                   + "\n4. Press 4 to add a Bus"
                   + "\n5. Press 5 to add a MotorCycle"
                   + "\n6. Return to previous menu"
                   + "\n0. Exit the application");
                try
                {
                    input = Utils.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    //Utils.Print("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        
                        Utils.Print("Enter the follwing details of the Car");
                        Utils.Print("Car brand");
                        var make = Utils.ReadLine();
                        if(Utils.CheckForInput(make))
                        {
                           
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Car Model");
                        var model = Utils.ReadLine();
                        if (Utils.CheckForInput(model))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Car Registration Number");
                        var regNo = Utils.ReadLine();
                        if (Utils.CheckForInput(regNo))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Car Color");
                        var color = Utils.ReadLine();
                        if (Utils.CheckForInput(color))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        var car = new Car(make, model, regNo, color);
                        garage.Add(car);
                        break;
                    case '2':
                        Utils.Print("Enter the follwing details of the Boat");
                        Utils.Print("Boat brand");
                        var bMake = Utils.ReadLine();
                        if (Utils.CheckForInput(bMake))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Boat Model");
                        var bModel = Utils.ReadLine();
                        if (Utils.CheckForInput(bModel))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Boat Registration Number");
                        var bRegNo = Utils.ReadLine();
                        if (Utils.CheckForInput(bRegNo))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Boat Color");
                        var bColor = Utils.ReadLine();
                        if (Utils.CheckForInput(bColor))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        var boat = new Boat(bMake, bModel, bRegNo, bColor);
                        garage.Add(boat);
                        break;
                    case '3':
                        Utils.Print("Enter the follwing details of the Plane");
                        Utils.Print("Plane brand");
                        var pMake = Utils.ReadLine();
                        if (Utils.CheckForInput(pMake))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Plane Model");
                        var pModel = Utils.ReadLine();
                        if (Utils.CheckForInput(pModel))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Plane Registration Number");
                        var pRegNo = Utils.ReadLine();
                        if (Utils.CheckForInput(pRegNo))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Plane Color");
                        var pColor = Utils.ReadLine();
                        if (Utils.CheckForInput(pColor))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Plane number of engines");
                        var pEngines = Utils.ReadLine();
                        int value;
                        if (Utils.CheckForInput(pEngines) || !int.TryParse(pEngines, out value))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        var plane = new Plane(pMake, pModel, pRegNo, pColor, int.Parse(pEngines));
                        garage.Add(plane);
                        break;
                    case '4':
                        Utils.Print("Enter the follwing details of the Bus");
                        Utils.Print("Bus brand");
                        var busMake = Utils.ReadLine();
                        if (Utils.CheckForInput(busMake))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Bus Model");
                        var busModel = Utils.ReadLine();
                        if (Utils.CheckForInput(busModel))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Bus Registration Number");
                        var busRegNo = Utils.ReadLine();
                        if (Utils.CheckForInput(busRegNo))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Bus Color");
                        var busColor = Utils.ReadLine();
                        if (Utils.CheckForInput(busColor))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Bus number of engines");
                        var busSeats = Utils.ReadLine();
                        int v;
                        if (Utils.CheckForInput(busSeats) || !int.TryParse(busSeats, out v))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        var bus = new Bus(busMake, busModel, busRegNo, busColor, int.Parse(busSeats));
                        garage.Add(bus);
                        break;
                    case '5':
                        Utils.Print("Enter the follwing details of the MotorCycle");
                        Utils.Print("Motorcycle brand");
                        var mMake = Utils.ReadLine();
                        if (Utils.CheckForInput(mMake))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Motorcycle Model");
                        var mModel = Utils.ReadLine();
                        if (Utils.CheckForInput(mModel))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Motorcycle Registration Number");
                        var mRegNo = Utils.ReadLine();
                        if (Utils.CheckForInput(mRegNo))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        Utils.Print("Motorcycle Color");
                        var mColor = Utils.ReadLine();
                        if (Utils.CheckForInput(mColor))
                        {
                            Console.WriteLine("Please enter some input!");
                            AddVehicleMenu();
                        }
                        var motorcycle = new Motorcycle(mMake, mModel, mRegNo, mColor);
                        garage.Add(motorcycle);
                        break;
                    case '6':
                        SecondMenu();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;
                }
            }

        }

    }
}
