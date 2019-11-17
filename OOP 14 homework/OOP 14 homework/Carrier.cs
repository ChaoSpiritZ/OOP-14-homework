using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14_homework
{
    class Carrier
    {
        public Vehicle[] _vehicles;

        public Carrier(Vehicle[] vehicles)
        {
            _vehicles = vehicles;
        }

        public override string ToString()
        {
            string allVehicles = "";
            for (int i = 0; i < _vehicles.Length; i++)
            {
                allVehicles += $"{_vehicles[i]}\n";
            }

            return allVehicles;
        }
    }
}
