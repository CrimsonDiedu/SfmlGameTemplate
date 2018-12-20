using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FSPG;

namespace PG2_Day_6
{
	class Program
	{
        public static int f;
        public static List<string> titles = new List<string>();
		static void Main(string[] args)
		{
            f = -1;
            string str = "";
            string[] title;
            using (StreamReader stream = new StreamReader("files/testFile.csv"))
            {
                while (!stream.EndOfStream)
                {
                    str = stream.ReadLine();
                    title = str.Split(',');
                    for (int i = 0; i < title.Length; i++)
                    {
                        titles.Add(title[i]);
                    }
                }
            }
            /*
            for(int i = 0; i < titles.Count; i++)
            {
                Console.Write(titles[i]);
            }
            */
            bool exit = false;
            string state = "Main";
            int response = 0;
            while (!exit)
            {
                Console.Clear();
                switch (state) {
                    case "Main":
                        Console.WriteLine("________________________________");
                        PrintTitles();
                        Console.WriteLine("________________________________");
                        Console.WriteLine("Please choose an option..");
                        Console.WriteLine("1.) Bubble Sort.");
                        Console.WriteLine("2.) Selection Sort.");
                        Console.WriteLine("3.) Insertion Sort.");
                        Console.WriteLine("4.) Randomize.");
                        Console.WriteLine("5.) Display lone values.");
                        response = Utility.ReadInt();
                        switch (response)
                        {
                            case 1:
                                state = "Bubble";
                                f = -f;
                                break;
                            case 2:
                                state = "Selection";
                                f = -f;
                                break;
                            case 3:
                                state = "Insertion";
                                f = -f;
                                break;
                            case 4:
                                Randomize();
                                break;
                            case 5:
                                state = "Display";
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Bubble":
                        BubbleSort();
                        state = "Main";
                            break;
                    case "Insertion":
                        InsertionSort();
                        state = "Main";
                        break;
                    case "Selection":
                        SelectionSort();
                        state = "Main";
                        break;
                    case "Display":
                        PrintTitles();
                        Console.ReadKey();
                        state = "Main";
                        break;
                    case "Randomize":
                        Randomize();
                        break;
                    default:
                        break;
                }
            }

		}

        static void PrintTitles()
        {
            for(int i = 0; i < titles.Count; i++)
            {
                Console.Write(titles[i]);
                Console.WriteLine();
            }
        }
        static void Randomize()
        {
            int j;
            string ind;
            
            for(int i = 0; i < titles.Count; i++)
            {
                j = Utility.Rand() % titles.Count;
                ind = titles[i];
                titles[i] = titles[j];
                titles[j] = ind;
            }
        }
        private static void BubbleSort()
        {
            bool swap = true;
            string temp;
            int comparison;
            // Loop through the entire list/array
            //PrintTitles();
            while (swap == true)
            {
                swap = false;
                for (int i = 0; i < titles.Count - 1; i++)
                {
                    
                    comparison = string.Compare(titles[i], titles[i + 1]);
                    if (comparison == f)
                    {
                        temp = titles[i];
                        titles[i] = titles[i + 1];
                        titles[i + 1] = temp;
                        swap = true;
                    }
                    // Compare the current index and the one right after it
                    // If they are out of order...
                    // Swap the values.

                    // If a swap has happened, repeat the process.  If not, all done!
                }
            }
        }
        private static void SelectionSort()
        {
            int smallpos = 0, comparison = 0;
            string temp;
            // Loop through the list.
            for (int i = 0; i < titles.Count; i++) {
                smallpos = i;
                for(int j = i; j < titles.Count; j++)
                {
                    comparison = string.Compare(titles[smallpos], titles[j]);
                    if(comparison == f)
                    {
                        smallpos = j;
                    }

                }if(smallpos != i)
                {
                    temp = titles[i];
                    titles[i] = titles[smallpos];
                    titles[smallpos] = temp;

                }

            }
            // Assume the current index is the smallest value.
            // Loop again, through ALL entries PAST the last loop index (don't want to compare things twice)

            // Did we find a smaller value?
            // Update the min_index to reflect the location of the new minimum value.

            // AFTER looping through all to find a new minimum... If there is a new min_index... swap it with the current value.


            PrintTitles();
            Console.ReadKey();
        }
		static public void InsertionSort()
		{
            int counted = 0, index;
            // Loop through the entire list
            for (int i = counted; i < titles.Count; i++)
            {
                index = i - 1;
                string temp = titles[i];
                while (index >= 0 && string.Compare(titles[index],temp) == f)
                {
                    titles[index + 1] = titles[index];
                    index--;
                }
                titles[index + 1] = temp;
            }
            PrintTitles();
            Console.ReadKey();
			// Create a counter variable equal to your current index variable
			// We're assuming that the beginning of the array is the sorted part.

			// Create an inner while loop that starts at the outer loop index, and goes to 0
			// Moving from our index toward the front of the array (i.e. the sorted part), checking to see if swaps are needed

			//	If the inner loop counter is greater than zero,
			// AND the value[loop counter] is less than value[loop counter - 1]
			// Swap
			// Decrement the while loop counter
		}
	}
}
