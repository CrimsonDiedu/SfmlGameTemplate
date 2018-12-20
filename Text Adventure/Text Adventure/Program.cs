using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Text_Adventure
{
    class Program
    {
        public static void Pause() {
            Thread.Sleep(2000);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("How To Make A McRib");
            Question1:
            Console.Clear();
            Console.WriteLine("Have you slaughtered a pig?");
            Console.WriteLine("1.) No");
            Console.WriteLine("2.) I think so");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "1" || response == "no")
            {
                Console.Clear();
                Console.WriteLine("Not that it matters, but for legal reasons, we must ask you to answer that question again");
                Pause();
                goto Question1;
            }
            else if (response == "2" || response == "i think so") {
                Console.WriteLine("Close enough. Do you recognize any of the pig parts as something you have eaten before");
                Console.WriteLine("1.) No");
                Console.WriteLine("2.) Yes");
                response = Console.ReadLine();
                response = response.ToLower();

                if (response == "1" || response == "No") {
                    Console.WriteLine("Form said parts into something vaguely resembling babyback ribs.");
                    Console.ReadKey();
                    Console.WriteLine("Cook usuing nearest available heat source");
                    Console.WriteLine("Cooked to a temperature safe for human consumption?");
                    Console.WriteLine("1.) No");
                    Console.WriteLine("2.) Yes");
                    Console.ReadLine();
                    
                    Console.WriteLine("As if it matters, this is McDonald's");
                    Console.WriteLine("Place on bun with pickles, onions and barbecue type sauce.");
                    Console.WriteLine("Do you want to eat it?");
                    Console.WriteLine("YESIDOGODHELPME!!!");
                    Console.ReadLine();

                }
                else if (response == "2" || response == "Yes")
                {
                    Console.WriteLine("Discard");
                }
            }
            else {
                Console.WriteLine("I didn't catch that, speak up");
                Pause();
                goto Question1;
            }

        }
    }
}
