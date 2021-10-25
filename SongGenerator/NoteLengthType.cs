using System;
using System.Collections.Generic;
using System.Text;

namespace SongGenerator
{
    public enum NoteLengthType
    {
        Semibreve, // = 1
        Minim,     // = 2
        Crotchet,  // = 4
        Quaver,    // = 8
        SemiQuaver // = 16
    }

    public static class NoteLengthConverter
    {
        public static NoteLengthType GetUserFriendlyNoteLength(int i)
        {
            var noteLength = i switch
            {
                1 => NoteLengthType.Semibreve,
                2 => NoteLengthType.Minim,
                4 => NoteLengthType.Crotchet,
                8 => NoteLengthType.Quaver,
                16 => NoteLengthType.SemiQuaver,
                _ => throw new NotImplementedException()
            };
            return noteLength;
        }
        public static int GetPlayableNoteLength(int i)
        {
            var noteLength = i switch
            {
                1 => 2000,
                2 => 1000,
                4 => 500,
                8 => 250,
                16 => 125,
                _ => throw new NotImplementedException()
            };
            return noteLength;
        }
    }
}
