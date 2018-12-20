using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace RanDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 500;
            int i = 0;

            int dx = Rand_Range(0, Console.WindowWidth);
            int dy = Rand_Range(0, Console.WindowHeight);
            string[,] tile = new string[" "," "];


            while (i < size) {
                int dir = Rand_Range(0, 3);

                if (dir == 4) {
                    dir = 0;
                }

                switch (dir) {
                    case 0:
                        dx++;
                        break;
                    case 1:
                        dy++;
                        break;
                    case 2:
                        dx--;
                        break;
                    case 3:
                        dy--;
                        break;
                    default:
                        break;
                }
                if (tile[dx, dy] == null) {
                    tile[dx, dy] = " ";
                }
            }

            

             int Rand_Range(int min, int max)
            {

                int res = 0;
                res = Utility.Rand() % max + 1;

                return res;

            }
        }

        
    }
}
