using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PocketMoney.Application.Repositories;

namespace PocketMoney.Application.Models.Users.Commands {
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand> {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler (IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle (CreateUserCommand request, CancellationToken cancellationToken) {
            var user = new Domain.Entities.User (request.Name, request.Email, request.Password);

            await _userRepository.CreateUserAsync (user);

            return await Task.FromResult (Unit.Value);
        }
    }
}