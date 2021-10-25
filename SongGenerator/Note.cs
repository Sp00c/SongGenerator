using System;
using System.Collections.Generic;
using System.Text;

namespace SongGenerator
{
    public class Note
    {
        public string Name { get; }
        public short Octave { get; }
        public float Frequency { get; }
        public Note(string name, short octave, float freq)
        {
            Name = name;
            Octave = octave;
            Frequency = freq;
        }
    }
}
