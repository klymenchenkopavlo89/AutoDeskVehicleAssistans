using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class VinSearch
    {
        public Vehicle FindByVin(string vin)
        {
            return VehicleDataBase.Vehicles
                .FirstOrDefault(v =>
                    v.Vin.Equals(vin, StringComparison.OrdinalIgnoreCase));
        }
        public void SearchByVin(NavigationManager navigationManager)
        {
            Console.WriteLine();
            Console.Write("Enter VIN: ");

            string vinSearch = Console.ReadLine();

            var vehicle = VehicleDataBase.Vehicles
                .FirstOrDefault(v =>
                    v.Vin.Equals(vinSearch, StringComparison.OrdinalIgnoreCase));

            if (vehicle != null)
            {
                VehicleInformation vehicleInformation = new VehicleInformation();
                VehicleMenu vehicleMenu = new VehicleMenu();

                navigationManager.Navigate(() => vehicleInformation.Show(vehicle, navigationManager));
                navigationManager.Navigate(() => vehicleMenu.Show(vehicle, navigationManager));

                navigationManager.ShowCurrent();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("VIN not found.");
            }
        }
    }
}
