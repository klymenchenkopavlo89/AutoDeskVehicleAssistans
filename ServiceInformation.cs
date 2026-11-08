using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class ServiceInformation
    {
        public void Show(NavigationManager navigationManager)
        {
            foreach (var service in ServiceDatabase.Services)
            {
                Console.WriteLine();
                Console.WriteLine("SERVICE INFORMATION");
                Console.WriteLine("--------------------");
                Console.WriteLine("Service Type: " + service.ServiceType);
                Console.WriteLine("Description: " + service.Description);
                Console.WriteLine("Interval: " + service.Interval);
            }
            Console.WriteLine();
            Console.WriteLine("0. Back");
            Console.WriteLine();

            Console.Write("Select option: ");
            string option = Console.ReadLine();

            if (option == "0")
            {
                navigationManager.Back();
            }
        }
    }
}
