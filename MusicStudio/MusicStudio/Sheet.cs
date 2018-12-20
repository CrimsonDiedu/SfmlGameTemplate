using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStudio
{
    class Sheet
    {
        List<Note> Song = new List<Note>();
        

        void AddNote(int tone, int pitch, int length)
        {
            Note n = new Note(tone, pitch, length);
            Song.Add(n);
        }
    }
}
