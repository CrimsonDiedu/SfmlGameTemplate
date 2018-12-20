using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading_test
{

    class Sheet
    {
        List<Note> notes;
        Sheet nextBar;
        int bpm = 1;
        string name = "New Sheet";
        public enum NOTE
        {
            C = 32,
            CS = 34,
            D = 36,
            E = 41,
            F = 43,
            FS = 46,
            G = 49,
            GS = 51,
            A = 55,
            AS = 58,
            B = 61,
        }
        public Sheet()
        {
            notes = new List<Note>();
        }
        public Sheet(int capacity)
        {
            notes = new List<Note>(capacity);
        }
        public Sheet(IEnumerable<Note> Collection)
        {
            notes = new List<Note>(Collection);
        }
        public void AddNote(string _note,int _octave, int d)
        {
            //
        }
        public Sheet(Sheet s)
        {
            notes = new List<Note>();
            while (notes.Count < s.notes.Count)
            {
                int ind = notes.Count;
                notes.Add(new Note(s.notes[ind]));
            }
        }
        public void AddNote(int f, int d)
        {
            Note n = new Note(f, d * bpm);
            notes.Add(n);
        }
        public void AddNote(NOTE baseNote, int octave, int d)
        {
            int note = (int)baseNote;
            for (int i = 1; i < octave; i++)
                note *= 2;
            Note n = new Note(note, d * bpm);
            notes.Add(n);
        }
        public void ReplaceNote(int ind, NOTE baseNote, int octave, int d)
        {
            if (ind < notes.Count)
            {
                int note = (int)baseNote;
                for (int i = 1; i < octave; i++)
                    note *= 2;
                Note n = new Note(note, d * bpm);
                notes[ind] = n;
            }
        }
        public void ReplaceNote(int ind, int f, int d)
        {
            if (ind < notes.Count)
            {
                notes[ind] = new Note(f, d*bpm);
            }
        }
        public void Play()
        {
            for (int i = 0; i < notes.Count; i++)
            {
                notes[i].Play();
            }
            if (nextBar != null)
            {
                nextBar.Play();
            }
        }
        public void SetBar(Sheet bar)
        {
            nextBar = bar;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }
    }

}
