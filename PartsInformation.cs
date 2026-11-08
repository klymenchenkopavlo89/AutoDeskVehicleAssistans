using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class PartsInformation
    {
        public void Show(NavigationManager navigationManager)
        {
            foreach (var part in PartsDatabase.PartsList)
            {
                Console.WriteLine();
                Console.WriteLine("PARTS INFORMATION");
                Console.WriteLine("--------------------");
                Console.WriteLine("Part number: " + part.PartNumber);
                Console.WriteLine("Part name: " + part.PartName);
                Console.WriteLine("Description: " + part.Description);
                Console.WriteLine();
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
