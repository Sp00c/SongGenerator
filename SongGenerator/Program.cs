using SongGenerator;
using System;
using System.Linq;

namespace SongGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jingleBellsNotes = { "B|4|4", "B|4|4", "B|4|2", "B|4|4", "B|4|4", "B|4|2", "B|4|4", "D|5|4", "G|4|4", "A|4|4", "B|4|1" };
            string[] doTheyKnowNotes = { "E|4|2", "A|3|2", "F#|4|2", "E|4|2", "F#|4|4", "E|4|4", "D|4|4", "C#|4|4", "D|4|4", "C#|4|4", "B|3|4", "A|3|2" };
            string[] goodKingWenceslasNotes = { "E|4|4", "E|4|4", "B|4|4", "B|4|4", "A|4|4", "G|4|4", "F#|4|4", "E|4|4", "D|4|4", "E|4|4", "F#|4|4", "G|4|4", "A|4|4", "B|4|1" };

            var noteService = new NoteService();
            var jingleBellsSong = Generator.CreateSong(jingleBellsNotes, noteService).ToList();
            var doTheyKnowSong = Generator.CreateSong(doTheyKnowNotes, noteService).ToList();
            var goodKingWenceslasSong = Generator.CreateSong(goodKingWenceslasNotes, noteService).ToList();

            goodKingWenceslasSong.ForEach(n => Console.Beep(n.Item1, n.Item2));
            doTheyKnowSong.ForEach(n => Console.Beep(n.Item1, n.Item2));
            jingleBellsSong.ForEach(n => Console.Beep(n.Item1, n.Item2));
        }
    }
}
