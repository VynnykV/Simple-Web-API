using Application.Common.Exceptions;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, UserDetailsVm>
    {
        private readonly INoteDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserDetailsQueryHandler(INoteDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UserDetailsVm> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                .FindAsync(request.Id);
            if (user == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }
            return _mapper.Map<UserDetailsVm>(user);
        }
    }
}
