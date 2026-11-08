using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class VehicleInformation
    {
        public void Show(Vehicle vehicle , NavigationManager navigationManager)
        {

            Console.WriteLine();
            Console.WriteLine("VEHICLE INFORMATION");
            Console.WriteLine("--------------------");
            Console.WriteLine("VIN: " + vehicle.Vin);
            Console.WriteLine("Model: " + vehicle.Model);
            Console.WriteLine("Year: " + vehicle.Year);
            Console.WriteLine("Engine: " + vehicle.Engine);

           // VehicleMenu vehicleMenu = new VehicleMenu();
           // vehicleMenu.Show(vehicle, navigationManager);
        }
    }
}
