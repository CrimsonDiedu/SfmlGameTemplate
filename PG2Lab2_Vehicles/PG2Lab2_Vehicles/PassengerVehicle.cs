using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Lab2_Vehicles
{
    class PassengerVehicle : Vehicle
    {
        public int NumberOfPassengers;
        public PassengerVehicle(int nop = 4)
        {
            NumberOfPassengers = nop;
        }

        public override void Print()
        {
            base.Print();
            Console.Write("\t np: " + NumberOfPassengers);
        }
        
    }
}
