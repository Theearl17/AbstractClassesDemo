using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = 2000,
                Make = "Chevy",
                Model = "Trash",

            };
            var motorcycle1 = new Motorcycle()
            {
                HasSideCart = true,
                Year = 2020,
                Make = "Ducatti",
                Model = "Roadster",
            };
            Vehicle vehicle1 = new Car()
            {
                Year = 2002,
                HasTrunk= true,
                Model = "Tahoe",
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Model = "Cruze",
                Year = 2000,
                Make = "Chevy",
                
            };   
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();


            }


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
          
        }
    }
}
