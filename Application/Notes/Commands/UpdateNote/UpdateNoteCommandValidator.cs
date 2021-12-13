using FluentValidation;

namespace Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(updateNoteCommand =>
                updateNoteCommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(updateNoteCommand =>
                updateNoteCommand.UserId).NotEmpty();
            RuleFor(updateNoteCommand =>
                updateNoteCommand.Id).NotEmpty();
        }
    }
}
