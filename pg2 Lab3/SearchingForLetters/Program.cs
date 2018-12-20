using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;
namespace SearchingForLetters
{
    class Program
    {
        //Random ranlet;

        static void Main(string[] args)
        {
            Random ranlet = new Random();
            char[] letters = new char[25];
            char c = '_';
            int count = 0;
            bool exit = false;
            int reps = 0;
            do {
                for (int i = 0; i < 25; i++)
                {
                    letters[i] = (char)(97 + ranlet.Next(0, 26));
                }
                Console.Write("Characters ");
                for (int i = 0; i < letters.Length; i++)
                {
                    Console.Write(letters[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Enter a letter: ");
                string response = Console.ReadLine();
                //char c;
                if (response.Length == 1) {
                    c = Convert.ToChar(response);
                }
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == c)
                    {
                        count++;
                    }
                }
                Console.WriteLine("The character " + c + " is found " + count + " times in the list.");
                Console.ReadKey();
                Console.WriteLine("enter any character to continue, type 'exit' to exit.");
                response = Console.ReadLine();
                if (response == "exit.")
                {
                    exit = true;
                }
                reps++;
                if(reps == 8)
                {
                    reps = 0;
                    Console.Clear();
                }
                
            }while(exit == false);
            Console.WriteLine("You are leaving now.");
            Console.ReadKey();
        }

        static void NewRandom()
        {
            
        }
    }
}
