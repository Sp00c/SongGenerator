using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongGenerator
{
    public class NoteService : INoteService
    {
        private static Func<Note, bool> CanBeHeard = n => n.Frequency > 37f;
        public IEnumerable<Note> AvailableNotes { get; }

        public NoteService()
        {
            AvailableNotes = DataSource.NoteData.Trim().Split("\r\n")
               .Select(
               x => x.Split('|'))
               .Select(x => new Note(x[0].ToString().Trim(), Convert.ToInt16(x[1]), Convert.ToSingle(x[2]))).Where(CanBeHeard);
        }
    }
}
