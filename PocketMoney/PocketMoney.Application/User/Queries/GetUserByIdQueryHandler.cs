using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PocketMoney.Application.Repositories;
using PocketMoney.Application.User.Commands;

namespace PocketMoney.Application.User.Queries
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<Unit> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            await _userRepository.GetUserByIdAsync(request.Id);

            return await Task.FromResult(Unit.Value);
        }
    }
}