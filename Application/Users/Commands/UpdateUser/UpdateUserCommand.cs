using MediatR;

namespace Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
