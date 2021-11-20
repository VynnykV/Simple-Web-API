using System;

namespace Application.Notes.Queries.GetNoteDetails
{
    public class NoteDetailsVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}