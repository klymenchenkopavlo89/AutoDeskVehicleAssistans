using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class ModelSearch
    {
        public void SearchByModel(NavigationManager navigationManager)
        {


            Console.WriteLine();
            Console.WriteLine("1. Prius");
            Console.WriteLine("2. Corolla");
            Console.WriteLine("3. RAV4");
            Console.WriteLine("0. Back");
            Console.WriteLine();

            Console.Write("Select model: ");
            string modelOption = Console.ReadLine();

            string selectedModel = "";

            if (modelOption == "1")
            {
                selectedModel = "Prius";
            }
            else if (modelOption == "2")
            {
                selectedModel = "Corolla";
            }
            else if (modelOption == "3")
            {
                selectedModel = "RAV4";
            }
            else if (modelOption == "0")
            {
                return;
            }

            var result = VehicleDataBase.Vehicles
                .Where(vehicle => vehicle.Model.Equals(selectedModel, StringComparison.OrdinalIgnoreCase));

            if (result.Any())
            {
                Console.WriteLine();
                Console.WriteLine("Search Results:");

                foreach (var Vehicle in result)
                {
                    Console.WriteLine(Vehicle.Model);
                }

                Console.WriteLine();
                Console.WriteLine("1. Vehicle Information");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                Console.WriteLine("Select option: ");
                string vehicleOption = Console.ReadLine();


                if (vehicleOption == "1")
                {
                    Vehicle vehicle = result.First();

                    VehicleInformation vehicleInformation = new VehicleInformation();
                    VehicleMenu vehicleMenu = new VehicleMenu();

                    navigationManager.Navigate(() => vehicleInformation.Show(vehicle, navigationManager));
                    navigationManager.Navigate(() => vehicleMenu.Show(vehicle, navigationManager));

                    navigationManager.ShowCurrent();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No Toyota vehicle found.");
                Console.WriteLine();

                Console.WriteLine("1. New search");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                Console.WriteLine("Select option: ");
                string notFoundOption = Console.ReadLine();

                if (notFoundOption == "1")
                {
                    return;
                }
            }
        }
    }
}
