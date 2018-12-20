using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStudio
{
    class Note
    {//13 notes 
        int tone = 1;
        int pitch = 1;
        int bar = 20;
        int length = 1;
        string note = "";

        public Note(int t, int p, int l) {
            tone = t;
            pitch = p;
            length = l;
        switch(tone){
                case 1:
                    note += "C ";
                    break;
                case 2:
                    note += "C# ";
                    break;
                case 3:
                    note += "D ";
                    break;
                case 4:
                    note += "D# ";
                    break;
                case 5:
                    note += "E ";
                    break;
                case 6:
                    note += "F ";
                    break;
                case 7:
                    note += "F# ";
                    break;
                case 8:
                    note += "G ";
                    break;
                case 9:
                    note += "G# ";
                    break;
                case 10:
                    note += "A ";
                    break;
                case 11:
                    note += "A# ";
                    break;
                case 12:
                    note += "B ";
                    break;

            }
        }

        void PlayNote()
        {
            int freq = (tone * 221)*pitch ;
            Console.Beep(freq, length * bar);
        }
    }
}
