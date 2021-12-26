using MediatR;


namespace Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommand : IRequest
    {
        public int UserId { get; set; }
        public int Id { get; set; }
    }
}
