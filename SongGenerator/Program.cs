using SongGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using static SongGenerator.Generator;

namespace SongGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PlaySong(IEnumerable<(int, int)> x) => x.ToList().ForEach(s => Console.Beep(s.Item1, s.Item2));

            string[] jingleBellsNotes = { "B|4|4", "B|4|4", "B|4|2", "B|4|4", "B|4|4", "B|4|2", "B|4|4", "D|5|4", "G|4|4", "A|4|4", "B|4|1" };
            string[] doTheyKnowNotes = { "E|4|2", "A|3|2", "F#|4|2", "E|4|2", "F#|4|4", "E|4|4", "D|4|4", "C#|4|4", "D|4|4", "C#|4|4", "B|3|4", "A|3|2" };
            string[] merryGentlemenNotes = { "E|4|4", "E|4|4", "B|4|4", "B|4|4", "A|4|4", "G|4|4", "F#|4|4", "E|4|4", "D|4|4", "E|4|4", "F#|4|4", "G|4|4", "A|4|4", "B|4|1" };

            var noteService = new NoteService();
            PlaySong(CreateSong(jingleBellsNotes, noteService));
            PlaySong(CreateSong(doTheyKnowNotes, noteService));
            PlaySong(CreateSong(merryGentlemenNotes, noteService));
        }
    }
}
