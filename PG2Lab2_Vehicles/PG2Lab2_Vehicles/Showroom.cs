using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Lab2_Vehicles
{
    class Showroom
    {
        Vehicle[] vehicle;
        public int Stored = 0;
        int size;
        public Showroom(int s = 4)
        {
            size = s;
            vehicle = new Vehicle[size];
        }

        public void AddVehicle(string make, string model, int year,int nop, int mbw, int type = 0)
        {
           
            if(type == 1)
            {
                PassengerVehicle v;
                v = new PassengerVehicle();
                vehicle[Stored] = v;
                v.make = make;
                v.model = model;
                v.year = year;
                v.NumberOfPassengers = nop;
                //    (make, model, year);
            }else if (type == 2)
            {
                Truck v = new Truck();
                vehicle[Stored] = v;
                v.make = make;
                v.model = model;
                v.year = year;
                v.NumberOfPassengers = nop;
                v.MaxBedWeight = mbw;
            }
            else
            {
                Vehicle v = new Vehicle();
                vehicle[Stored] = v;
            }
            if (Stored < size)
            {
                Stored++;
            }
        }
        public bool AtMax()
        {
            return (Stored == size);
        }
        public void Print()
        {
            if (Stored > 0)
            {
                for (int i = 0; i < Stored; i++)
                {
                    vehicle[i].Print();
                    Console.WriteLine();
                }
            }
        }
    }
}
