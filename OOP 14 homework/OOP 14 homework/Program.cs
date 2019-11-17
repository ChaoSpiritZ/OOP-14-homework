using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mazda = new Car(4, 4, "mazda");
            Car audi = new Car(2, 4, "audi");
            Motorcycle motor = new Motorcycle(1, 2, "motor");
            Motorcycle sonic = new Motorcycle(2, 2, "sonic");

            Vehicle[] vehicles1 = new Vehicle[4];
            vehicles1[0] = mazda;
            vehicles1[1] = audi;
            vehicles1[2] = motor;
            vehicles1[3] = sonic;

            Vehicle[] vehicles2 = new Vehicle[2];
            vehicles2[0] = new Car(4, 4, "audi");
            vehicles2[1] = new Motorcycle(2, 2, "sonic");
            Carrier carrier = new Carrier(vehicles2);

            PrintVehicle(mazda);
            PrintVehicle(sonic);
            Console.WriteLine();
            PrintVehicles(vehicles2);

            Console.WriteLine();
            Console.WriteLine("CARRIER TIME:");
            Console.WriteLine(carrier);
        }

        static void PrintVehicle(Vehicle vehicle)
        {
            Console.WriteLine("model: " + vehicle._model);
            Console.WriteLine(vehicle);
        }

        static void PrintVehicles(Vehicle[] vehicles)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine(vehicles[i]);
            }
        }
    }
}
