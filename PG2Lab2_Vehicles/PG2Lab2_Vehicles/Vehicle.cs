using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Lab2_Vehicles
{
    class Vehicle
    {
        public string make;
        public string model;
        public int year;

        public Vehicle(string _make = "Nissan", string _model = "Maxima", int _year = 2000)
        {
            make = _make;
            model = _model;
            year = _year;


        }

        virtual public void Print()
        {
            Console.Write("|-|" + year + " Make: " + make + "\t Model: " + model);
        }
        
    }
}
