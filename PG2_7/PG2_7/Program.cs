using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_Day_7
{
    class Program
    {
        public static void Test_1()
        {// - AddHead:
        LinkedList<int> ints = new LinkedList<int>();

            for (int i = 0; i <= 50; i += 5)
                ints.AddHead(i);

            Console.WriteLine("-- Testing AddHead --");
            ints.Print();
            }
        public static void Test_2()
        {
            LinkedList<int> ints = new LinkedList<int>();

            for (int i = 0; i <= 50; i += 5)
                ints.AddHead(i);

            Console.WriteLine("-- Testing Remove (No Duplicates) --");
            for (int i = 0; i <= 60; i += 10)
                Console.WriteLine("Removing " + i.ToString() + "s: " + ints.Remove(i) + " removed.");

            Console.WriteLine();
            Console.WriteLine("Remaining List Contents:\n");
            ints.Print();
        }
        public static void Test_3()
        {
            //Test 3 - Remove(w / Duplicates)
        // NOTE: Be sure AddHead is working correctly before using this test.
        LinkedList<int> ints = new LinkedList<int>();

            for (int i = 0; i <= 50; i += 5)
            {
                ints.AddHead(i);
                ints.AddHead(i);
            }
            Console.WriteLine("-- Testing Remove (Duplicates) --");

            for (int i = 0; i <= 60; i += 10)
                Console.WriteLine("Removing " + i.ToString() + "s: " + ints.Remove(i) + " removed.");

            Console.WriteLine("Remaining List Contents:");
            ints.Print();
        }
        /*public static void Test_4()
        {
            LinkedList<String> strings = new LinkedList<String>();

            strings.AddHead("strings.");
            strings.AddHead("of");
            strings.AddHead("list");
            strings.AddHead("a");
            strings.AddHead("is");
            strings.AddHead("This");

            Console.WriteLine("--- Testing RemoveAt ---");
            Console.WriteLine("Before Removing:");

            strings.Print();

            Console.WriteLine();
            Console.WriteLine("Removing at index 4: " + (strings.RemoveAt(4) ? "Succeeded" : "Failed"));
            Console.WriteLine("Removing at index 4: " + (strings.RemoveAt(4) ? "Succeeded" : "Failed"));
            Console.WriteLine();

            Console.WriteLine("After Removing:");
            strings.Print();

            Console.WriteLine("Clearing the List...");
            while (strings.RemoveAt(0)) { }
            Console.WriteLine("List Contents:");
            strings.Print();

            Console.WriteLine("Adding \"Post-clear test\"...");
            strings.AddHead("Post-clear test");

            Console.WriteLine("List Contents:");
            strings.Print();

            Console.WriteLine("Testing Error Checking:");
            Console.WriteLine("Trying to remove at index 10: " + (strings.RemoveAt(10) ? "Succeeded" : "Failed"));
            Console.WriteLine("Trying to remove at index -1: " + (strings.RemoveAt(-1) ? "Succeeded" : "Failed"));

        }
        */
        public static void Test_5()
        {
            LinkedList<String> strings = new LinkedList<String>();

            Console.WriteLine("-- Testing InsertAt --");
            Console.WriteLine("List Contents:");
            strings.AddHead("end.");
            strings.AddHead("This");
            strings.Print();

            Console.WriteLine("Inserting \"the\" to index 1: " + (strings.InsertAt(1, "the") ? "Succeeded" : "Failed"));
            Console.WriteLine("Inserting \"is\" to index 1: " + (strings.InsertAt(1, "is") ? "Succeeded" : "Failed"));
            strings.Print();//
            Console.WriteLine("List Contents:");
            strings.Print();

            Console.WriteLine("Testing Error Checking:");
            Console.WriteLine("Inserting \"shouldn't work\" to index -1: " + (strings.InsertAt(-1, "shouldn't work") ? "Succeeded" : "Failed"));
            Console.WriteLine("Inserting \"shouldn't work\" to index 10: " + (strings.InsertAt(10, "shouldn't work") ? "Succeeded" : "Failed"));

        }
        static void Main(string[] args)
        {
            Test_5
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                ();
            Console.ReadKey();
            //Test 2 - Remove(No Duplicates)
	    // NOTE: Be sure AddHead is working correctly before using this test.
            /*
            
            Test 4 - RemoveAt
	// NOTE: Be sure AddHead is working correctly before using this test.
        
            Test 5 - InsertAt
        // NOTE: Be sure AddHead is working correctly before using this test.
            */
        }
    }
}
