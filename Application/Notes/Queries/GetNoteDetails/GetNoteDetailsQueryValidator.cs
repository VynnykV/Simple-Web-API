using FluentValidation;

namespace Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
            RuleFor(getNoteDetailsQuery =>
                getNoteDetailsQuery.Id).NotEmpty();
            RuleFor(getNoteDetailsQuery =>
                getNoteDetailsQuery.UserId).NotEmpty();
        }
    }
}
