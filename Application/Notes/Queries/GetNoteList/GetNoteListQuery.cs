using MediatR;

namespace Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQuery : IRequest<NoteListVm>
    {
        public int UserId { get; set; }
    }
}
