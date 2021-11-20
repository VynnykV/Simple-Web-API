using MediatR;

namespace Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
