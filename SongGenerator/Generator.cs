using System;
using System.Collections.Generic;
using System.Linq;

namespace SongGenerator
{
    public static class Generator
    {
        private static Func<string[], IEnumerable<string[]>> CleanedUpNoteData = d => d.Select(s => s.Split("|", StringSplitOptions.RemoveEmptyEntries));
        private static Func<string, int> GetNoteLength = x => NoteLengthConverter.GetPlayableNoteLength(Convert.ToInt32(x));
        private static Func<Note, bool> MatchingNoteData(string[] s) => x => x.Name == s[0] && x.Octave == Convert.ToInt16(s[1]);
        private static Func<string[], ValueTuple<int, int>> NotePitchAndLength(IEnumerable<Note> n) => s => 
            (Convert.ToInt32(n.First(MatchingNoteData(s)).Frequency), GetNoteLength(s[2]));

        public static IEnumerable<ValueTuple<int, int>> CreateSong(string[] notes, INoteService service) => 
            CleanedUpNoteData(notes).Select(NotePitchAndLength(service.AvailableNotes));
    }
}
