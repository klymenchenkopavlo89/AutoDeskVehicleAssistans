using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class VehicleMenu
    {
        public void Show(Vehicle vehicle, NavigationManager navigationManager)
        {
            Console.WriteLine();
            Console.WriteLine("VEHICLE: " + vehicle.Model);
            Console.WriteLine("VIN: " + vehicle.Vin);
            Console.WriteLine();

            Console.WriteLine("1. Service Information");
            Console.WriteLine("2. Parts Information");
            Console.WriteLine("0. Back");

            Console.WriteLine();
            Console.Write("Select option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                ServiceInformation serviceInformation = new ServiceInformation();

                navigationManager.Navigate(() => serviceInformation.Show(navigationManager));
                navigationManager.ShowCurrent();
            }

            if (option == "2")
            {
                PartsInformation partsInformation = new PartsInformation();

                navigationManager.Navigate(() => partsInformation.Show(navigationManager));
                navigationManager.ShowCurrent();
            }

            if (option == "0")
            {
                navigationManager.Back();
                return;
            }
        }
    }
}
