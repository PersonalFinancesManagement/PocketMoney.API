using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PocketMoney.Application.Exceptions;
using PocketMoney.Application.Repositories;
using PocketMoney.Application.User.Commands;

namespace PocketMoney.Application.User.Queries
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, object>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<object> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetUserByIdAsync(request.Id);

            if (result == null)
            {
                throw new NotFoundException("User", "Id", request.Id);
            }

            return result;
        }
    }
}