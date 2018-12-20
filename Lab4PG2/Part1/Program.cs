using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory items = new Inventory();
            items.LoadInventoryFromFile("files\\ItemListA.txt");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Loading List A to current inventory...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            items.ShowInventory(2);
            int itemCount = items.GetEntryCount();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding items from List B to current inventory...");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            items.AddInventoryFromFile("files\\ItemListB.txt");
            items.ShowInventory(Console.CursorTop);
            items.WriteInventoryToFile("files\\ItemListC.txt");
            Console.ReadKey();
        }
    }
}
