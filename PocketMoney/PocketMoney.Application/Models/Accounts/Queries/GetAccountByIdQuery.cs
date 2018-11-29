using MediatR;

namespace PocketMoney.Application.Models.Accounts.Queries
{
    public class GetAccountByIdQuery : IRequest<object>
    {
        public GetAccountByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}