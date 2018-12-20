using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace Blackjack.myCards
{
    public class Assist
    {
        int Range(int min, int max)
        {
            int val;
            val = Utility.Rand()%(max - min) + Math.Abs(min);
            return val;
        }
    }


}
