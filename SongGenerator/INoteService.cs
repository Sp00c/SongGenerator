using System;
using System.Collections.Generic;
using System.Text;

namespace SongGenerator
{
    public interface INoteService
    {
        IEnumerable<Note> AvailableNotes { get; }
    }
}
