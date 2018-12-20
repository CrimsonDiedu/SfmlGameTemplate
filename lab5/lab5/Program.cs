using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;
using System.IO;

namespace lab5
{

    class Program
    {
        

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            bool program_end = false;

            string str;
            string[] temp = new string[2];

            using (StreamReader stream = new StreamReader("files\\variableTypes.txt"))
            {
                while (!stream.EndOfStream)
                {
                    str = stream.ReadLine();
                    temp = str.Split('|');
                    list.Add(temp[0] + " - " + temp[1]);
                    dictionary.Add(temp[0], Convert.ToInt32(temp[1]));

                }
            }
            Console.WriteLine("Loading String");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("String Loaded. . . Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            int response = 0, found = 0, exact = 0;
            do
            {
                string strng = "";

                do
                {
                    Console.WriteLine("1. Search through list.");
                    Console.WriteLine("2. Search through dictionary.");
                    Console.WriteLine("3. Exit.");
                    response = Utility.ReadInt();
                } while (!Utility.IsReadGood());
                if (response != 3) {
                    do
                    {
                        Console.WriteLine("Please enter a keyword to aid your search.");
                        strng = Console.ReadLine();
                    } while (strng == "");
                }
                do
                {
                    Console.WriteLine("1. Search for an exact match.");
                    Console.WriteLine("2. Search for a non-exact match.");
                    
                    exact = Utility.ReadInt();
                } while (!Utility.IsReadGood());
                switch (response)
                {
                    case 1:

                        found = 0;
                        strng = strng.ToLower();
                        string result = "";

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (exact == 1)
                            {
                                if (list[i] == strng)
                                {
                                    found++;
                                    result += strng + "\n";
                                    Console.WriteLine(list[i]);
                                }
                            }
                            else if (exact == 2)
                            {
                                if (list[i].Contains(strng))
                                {
                                    found++;
                                    result += strng + "\n";
                                    Console.WriteLine(list[i]);
                                }
                            }
                        }
                        Console.WriteLine("found ''" + strng + "'' " + found + " times");
                        Console.ReadKey();
                        break;
                    case 2:
                        found = 0;
                        foreach (KeyValuePair<string, int> item in dictionary)
                        {
                            if (exact == 1)
                            {
                                if(item.Key == strng ||item.Value == Convert.ToInt32(strng))
                                {
                                    found++;
                                    Console.WriteLine("Key-" + item.Key + " Value-" + item.Value);
                                }
                            }
                            else if (exact == 2)
                            {
                                if (item.Key.Contains(strng))
                                {
                                    found++;
                                    Console.WriteLine("Key-" + item.Key + " Value-" + item.Value);
                                }
                            }
                        }
                        Console.WriteLine("found ''" + strng + "'' " + found + " times");
                        Console.ReadKey();
                        break;
                    case 3:
                        program_end = true;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (program_end == false);



        }
    }
}
