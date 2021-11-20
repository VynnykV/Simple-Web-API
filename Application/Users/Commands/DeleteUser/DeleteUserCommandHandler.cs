using Application.Common.Exceptions;
using Application.Interfaces;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Users.Commands.DeleteUser
{
    class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly INoteDbContext _dbContext;

        public DeleteUserCommandHandler(INoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Users
                .FindAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }
            _dbContext.Users.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
