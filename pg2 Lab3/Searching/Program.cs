using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randInt = new List<int>();
            Random random = new Random();
            int rand;
            int max = 100;
            int min = 1;
            int smax = min;
            int smin = max;
            int smallest = max;
            int largest = min;

            for(int i = 0; i < 50; i++)
            {
                rand = (random.Next(1,5) % max) + min;
                randInt.Add(rand);
            }

            for (int i = 0; i < randInt.Count; i++)
            {
                int j = randInt[i];
                if (j > largest)
                {
                    largest = j;
                }

                if (j < smallest)
                {

                    smallest = j;
                }

            }
            for (int i = 0; i < randInt.Count; i++)
            {
                int j = randInt[i];
                if (j < smin && j != smallest)
                {
                    smin = j;
                }
                else if (j > smax && j != largest)
                {

                    smax = j;
                }

            }
            /*
            smin = randInt[0];
            smax = smallest;
            for(int i = 0; i < randInt.Count; i++)
            {
                int j = randInt[i]; 
                if (j < smin && j != smallest)
                {
                    smin = j;
                }
                if (j > smax && j != largest)
                {
                    smax = j;
                }
            }
            //*/
            Console.WriteLine("Printing random list");
            for (int i = 0; i < randInt.Count; i++)
            {
                
                Console.Write(randInt[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Largest and smallest values:");
            Console.WriteLine("Smallest: " + smallest);
            Console.WriteLine("Largest: " + largest);
            Console.WriteLine();
            Console.WriteLine("Second smallest and second largest values");
            Console.WriteLine("Smallest: " + smin);
            Console.WriteLine("Largest: " + smax);
            Console.WriteLine();
            Console.WriteLine("Printing list with second largest and smallest values removed");
            for (int i = 0; i < randInt.Count; i++)
            {
                if(randInt[i] == smin || randInt[i] == smax)
                {
                    randInt.RemoveAt(i);
                    if(i > 0)
                        i--;
                    if (i >= randInt.Count)
                        break;
                    
                }
                Console.Write(randInt[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
