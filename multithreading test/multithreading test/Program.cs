using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading_test
{
    class Program
    {
        public static void RunBeeps()
        {
            for(int i = 1; i < 17; i++)
            {
                Console.Beep(40 * i, 20);
            }

        }
        static void Main(string[] args)
        {
            Interface _interface = new Interface();
            
            _interface.Run();
            
        }
    }
}
