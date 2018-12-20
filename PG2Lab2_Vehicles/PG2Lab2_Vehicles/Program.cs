using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace PG2Lab2_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = "Main";
            bool exit = false;
            int response;
            string make;
            string model;
            int year;
            int nop;
            int mcw;
            
            Showroom showroom = new Showroom();
            //TestRun();
            do
            {

                switch (state)
                {
                    case "Main":
                        Console.Clear();
                        Console.WriteLine("1. Add a passenger vehicle");
                        Console.WriteLine("2. Add a truck");
                        Console.WriteLine("3. Show vehicle list");
                        Console.WriteLine("4. Exit");
                        response = Utility.ReadInt();
                        if(response == 1)
                        {
                            state = "AddPassenger";
                            break;
                        }
                        else if(response == 2)
                        {
                            state = "AddTruck";
                            break;
                        }
                        else if(response == 3)
                        {
                            state = "ShowVehicles";
                            
                            break;
                        }
                           else if(response == 4)
                        {
                            exit = true;
                        }
                        break;
                    case "AddPassenger":
                        Console.Clear();
                        if (showroom.AtMax())
                        {
                            Console.WriteLine("No More Space In Storeroom!");
                            state = "Main";break;
                        }
                        Console.WriteLine("Enter Passenger Vehicle's Make");
                         make = Console.ReadLine();
                        if (make == "")
                        {
                            Console.Write("Please Enter a value;");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter Model");
                        model = Console.ReadLine();
                        if (model == "")
                        {
                            Console.Write("Please Enter a value;");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter Year");
                        year = Utility.ReadInt(); 
                        if (!Utility.IsReadGood()) {
                            Console.WriteLine("Invalid Number");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter Number of Passengers");
                        nop = Utility.ReadInt();
                        if (Utility.IsReadGood())
                        {
                            showroom.AddVehicle(make,model,year,nop,0,1);
                            state = "Main";
                            break;
                        }
                        Console.WriteLine("Invalid Year");
                        Console.ReadKey();
                        break;
                    case "AddTruck":
                        Console.Clear();
                        if (showroom.AtMax())
                        {
                            Console.WriteLine("No More Space In Storeroom!");
                            state = "Main";
                            break;
                        }
                        Console.WriteLine("Enter Truck Vehicle's Make");
                        make = Console.ReadLine();
                        if (make == "")
                        {
                            Console.Write("Please Enter a value;");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter Model");
                        model = Console.ReadLine();
                        if (model == "")
                        {
                            Console.Write("Please Enter a value;");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter Year");
                        year = Utility.ReadInt(); 
                        if (!Utility.IsReadGood())
                        {
                            Console.WriteLine("Invalid Number");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Enter Number of Passengers");
                        nop = Utility.ReadInt();
                        if (!Utility.IsReadGood())
                        {
                            Console.WriteLine("Invalid Number");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Enter Maximum Bed Carry Weight");
                        mcw = Utility.ReadInt();
                        if (Utility.IsReadGood())
                        {
                            
                            showroom.AddVehicle(make,model,year,nop,mcw,2);
                            state = "Main";
                            break;
                        }
                        else
                        {

                            Console.WriteLine("Invalid Number");
                            Console.ReadKey();
                        }
                        break;
                        
                        //addtruck to vehicle array
                    case "ShowVehicles":
                        Console.Clear();
                        showroom.Print();
                        Console.ReadKey();
                        state = "Main";
                        //showroom prints vehicles
                        break;
                    default:
                        break;
                            
                }
            }
            while (exit == false);
        
        }
        static void TestRun()
        {
            Vehicle v = new Vehicle();
            v.Print();
            Console.WriteLine();
            Vehicle t = new Truck();
            t.Print();
        }
        static bool TestInt()
        {
            if (!Utility.IsReadGood())
            {
                Console.WriteLine("Invalid Number");
                Console.ReadKey();
                return false;
            }
            else
            {
                return true;
            }
        }
        
        }
    }
