using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PocketMoney.Application.Repositories;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Application.User.Commands {
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand> {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler (IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle (CreateUserCommand request, CancellationToken cancellationToken) {
            var user = new UserModel (request.Name, request.Email, request.Password);

            await _userRepository.CreateUserAsync (user);

            return await Task.FromResult (Unit.Value);
        }
    }
}