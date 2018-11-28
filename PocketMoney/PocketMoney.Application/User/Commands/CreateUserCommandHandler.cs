using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Application.User.Commands {
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand> {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler (IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public Task<Unit> Handle (CreateUserCommand request, CancellationToken cancellationToken) {
            var user = new UserModel (request.Name, request.Email, request.Password);

            _userRepository.CreateUserAsync (user);

            return Task.FromResult (Unit.Value);
        }
    }
}