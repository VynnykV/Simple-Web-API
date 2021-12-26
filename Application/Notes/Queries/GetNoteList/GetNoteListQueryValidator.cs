using FluentValidation;

namespace Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator()
        {
            RuleFor(getNoteListQuery =>
                getNoteListQuery.UserId).NotEmpty();
        }
    }
}
