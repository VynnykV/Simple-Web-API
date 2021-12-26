using MediatR;


namespace Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommand : IRequest
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
