using MediatR;

namespace PocketMoney.Application.Models.Users.Queries
{
    public class GetUserByIdQuery : IRequest<object>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}