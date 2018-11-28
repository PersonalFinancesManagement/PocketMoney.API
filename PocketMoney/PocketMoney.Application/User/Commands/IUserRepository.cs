using System.Threading.Tasks;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Application.User.Commands {
    public interface IUserRepository {
        Task CreateUserAsync (UserModel user);
    }
}