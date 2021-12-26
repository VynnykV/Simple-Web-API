﻿using FluentValidation;

namespace Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(createNoteCommand =>
                createNoteCommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(createNoteCommand =>
                createNoteCommand.UserId).NotEmpty();
        }
    }
}
