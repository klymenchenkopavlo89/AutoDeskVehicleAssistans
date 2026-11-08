using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class PartsDatabase
    {
        public static List<Part> PartsList = new List<Part>
        {
            new Part
            {
                PartNumber = "P001-OilF",
                PartName = "Oil Filter",
                Description = "High-quality oil filter for Toyota vehicles.",
            },
            new Part
            {
                PartNumber = "P002-AirF",
                PartName = "Air Filter",
                Description = "Durable air filter for optimal engine performance.",

            },
            new Part
            {
                PartNumber = "P003-OilE",
                PartName = "Engine Oil",
                Description = "High-performance engine oil for Toyota vehicles.",
                OilType = "Synthetic",
                OilQuantity = 4.2
            }
        };
    }
}
