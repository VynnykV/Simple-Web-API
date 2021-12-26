using Application.Common.Exceptions;
using Application.Interfaces;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteHandler : IRequestHandler<DeleteNoteCommand>
    {
        private readonly INoteDbContext _dbContext;

        public DeleteNoteHandler(INoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes.FindAsync(request.Id,cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
                throw new NotFoundException(nameof(Note),request.Id);

            _dbContext.Notes.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
