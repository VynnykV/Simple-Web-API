using FluentValidation;

namespace Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(deleteNoteCommand =>
                deleteNoteCommand.Id).NotEmpty();
            RuleFor(deleteNoteCommand =>
                deleteNoteCommand.UserId).NotEmpty();
        }
    }
}
