using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class ServiceDatabase
    {
        public static List<Service> Services = new List<Service>
        {
            new Service
            {
                ServiceType = "Oil Change",
                Description = "Change engine oil and replace oil filter.",
                Interval = "Every 5,000 miles or 6 months"
            },
            new Service
            {
                ServiceType = "Tire Rotation",
                Description = "Rotate tires to ensure even wear.",
                Interval = "Every 7,500 miles or 12 months"
            },
            new Service
            {
                ServiceType = "Brake Inspection",
                Description = "Inspect brake pads, rotors, and fluid levels.",
                Interval = "Every 10,000 miles or 12 months"
            }
        };
    }
}
