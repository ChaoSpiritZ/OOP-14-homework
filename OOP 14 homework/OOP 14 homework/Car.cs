using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14_homework
{
    class Car : Vehicle
    {

        public int _numberOfDoors;

        public Car(int numberOfDoors,int numberOfWheels, string model)
        {
            _numberOfWheels = numberOfWheels;
            _model = model;
            _numberOfDoors = numberOfDoors;
        }

        public override int GetMaxNumOfPassengers()
        {
            if(_numberOfDoors == 2)
            {
                return 2;
            }
            else if(_numberOfDoors == 4)
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }

        public override int GetMaxSpeed()
        {
            if(_model.ToLower() == "audi")
            {
                return 150;
            }
            else if(_model.ToLower() == "mazda")
            {
                return 130;
            }
            else
            {
                return 140;
            }
            
        }

        public override string ToString()
        {
            return base.ToString() + $", number of doors: {_numberOfDoors}";
        }
    }
}
