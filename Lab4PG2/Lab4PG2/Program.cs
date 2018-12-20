using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Part_1
{
    class Program
    {
        private static List<int> ReadNumbersFromFile(string filePath)
        {
            List<int> ints = new List<int>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                for(int i = 0; !sr.EndOfStream; i++)
                {
                    int temp = Convert.ToInt32(sr.ReadLine());
                    ints.Add(temp);
                }
            }

            return ints;
        }
        private static int SumNumbers(List<int> numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static float AverageNumbers(List<int> numbers)
        {
            int sum = SumNumbers(numbers);
            float average = (float)sum / numbers.Count;
            return average;
        }

        private static void WriteOddNumbersToFile(List<int> numbers, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        sw.WriteLine(numbers[i]);
                    }

                }
            }
        }

        private static void WriteEvenNumbersToFile(List<int> numbers, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sw.WriteLine(numbers[i]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = ReadNumbersFromFile("files\\numbers.txt");
            PrintNumbers(numbers);

            int total = SumNumbers(numbers);
            PrintTotal(total);

            float average = AverageNumbers(numbers);
            PrintAverage(average);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Writing even and odd numbers to files...");
            Console.WriteLine("Reading even and odd numbers back from files...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            WriteOddNumbersToFile(numbers, "files\\numbers_odd.txt");
            WriteEvenNumbersToFile(numbers, "files\\numbers_even.txt");

            List<int> evens = ReadNumbersFromFile("files\\numbers_even.txt");
            PrintNumbers(evens);

            total = SumNumbers(evens);
            PrintTotal(total);

            average = AverageNumbers(evens);
            PrintAverage(average);

            List<int> odds = ReadNumbersFromFile("files\\numbers_odd.txt");
            PrintNumbers(odds);

            total = SumNumbers(odds);
            PrintTotal(total);

            average = AverageNumbers(odds);
            PrintAverage(average);

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ReadKey();
        }

        private static void PrintAverage(float average)
        {
            Console.Write("Average of the numbers:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(average);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void PrintTotal(int total)
        {
            Console.Write("Sum of the numbers: \t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(total);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine("Numbers from the file: ");
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}