using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PocketMoney.Application.Exceptions;
using PocketMoney.Application.Repositories;

namespace PocketMoney.Application.Models.Accounts.Queries
{
    public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIdQuery, object>
    {
        private readonly IAccountRepository _accountRepository;

        public GetAccountByIdQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<object> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _accountRepository.GetAccountByIdAsync(request.Id);

            if (result == null)
            {
                throw new NotFoundException("Account", "Id",request.Id);
            }
            
            return result;
        }
    }
}