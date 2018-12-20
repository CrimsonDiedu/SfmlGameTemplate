using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_List_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prime = new List<int>();
            bool isprime;
            for (int i = 1; i < 100; i++) {
                isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                prime.Add(i);
                }
                
            }
            for(int i = 0; i < prime.Count; i++)
            {
                Console.Write(prime[i] + " | ");
            }
            Console.ReadKey();
        }
    }
}
