using Application.Interfaces;
using Domain;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, int>
    {
        private readonly INoteDbContext _dbContext;

        public CreateNoteCommandHandler(INoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            var note = new Note
            {
                UserId = request.UserId,
                Title = request.Title,
                Details = request.Details,
                CreationDate = DateTime.Now
            };
            await _dbContext.Notes.AddAsync(note);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return note.Id;
        }

    }
}
