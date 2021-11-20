using System.Collections.Generic;

namespace Application.Notes.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IEnumerable<NoteLookupDto> Notes { get; set; }
    }
}
