using MediatR;

namespace PocketMoney.Application.User.Queries
{
    public class GetUserByIdQuery : IRequest<object>
    {
        public GetUserByIdQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }
    }
}