using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Lab2_Vehicles
{
    class Truck : PassengerVehicle
    {
        public int MaxBedWeight;

        public Truck(int mbw = 100)
        {
            MaxBedWeight = mbw;
        }

        public override void Print()
        {
            base.Print();
            Console.Write("\t np: " + NumberOfPassengers +"\t Weight Limit: " + MaxBedWeight);
        }
        

    }
}
