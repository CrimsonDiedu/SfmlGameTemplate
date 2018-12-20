using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading_test
{
    class Note
    {
        int freq;
        int duration;
        public Note(int f, int d)
        {
            freq = f;
            duration = d;
        }
        public Note(Note n)
        {
            freq = n.freq;
            duration = n.duration;
        }
        public void Play()
        {
            Console.Beep(freq, duration);
        }
        public override string ToString()
        {
            return "Freq: "+freq+" Dur: "+duration;
        }
    }
}
