using MediatR;

namespace Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQuery : IRequest<NoteDetailsVm>
    {
        public int UserId { get; set; }
        public int Id { get; set; }
    }
}
