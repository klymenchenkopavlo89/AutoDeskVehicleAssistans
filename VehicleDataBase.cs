using System;
using System.Collections.Generic;
using System.Text;

namespace ToyotaVehicleSystem
{
    internal class VehicleDataBase
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>
        {
            new Vehicle
            {
                Vin = "TESTVIN01",
                Model = "Prius",
                Year = 2020,
                Engine = 1.8
            },
            new Vehicle
            {
                Vin = "TESTVIN02",
                Model = "Corolla",
                Year = 2021,
                Engine = 1.8
            },
            new Vehicle
            {
                Vin = "TESTVIN03",
                Model = "RAV4",
                Year = 2022,
                Engine = 2.5
            }
        };
    }
}
