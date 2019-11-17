using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14_homework
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        //public Vehicle(int numberOfWheels, string model)
        //{
        //    _numberOfWheels = numberOfWheels;
        //    _model = model;
        //}

        public abstract int GetMaxNumOfPassengers();

        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"model: {_model}, number of wheels: {_numberOfWheels}, number of passengers: {GetMaxNumOfPassengers()}, max speed: {GetMaxSpeed()} ";
        }
    }
}
