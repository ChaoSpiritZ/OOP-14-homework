using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14_homework
{
    class Motorcycle : Vehicle
    {
        public int _numberOfHandBrakes;

        public Motorcycle(int numberOfHandBrakes, int numberOfWheels, string model)
        {
            _numberOfWheels = numberOfWheels;
            _model = model;
            _numberOfHandBrakes = numberOfHandBrakes;
        }

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            if(_model.ToLower() == "sonic")
            {
                return 5000;
            }
            else
            {
                return 230;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", number of hand brakes: {_numberOfHandBrakes}";
        }
    }
}
