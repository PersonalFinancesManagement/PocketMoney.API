using System.Threading.Tasks;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Application.Repositories {
    public interface IUserRepository {
        Task CreateUserAsync (UserModel user);
        Task<object> GetUserByIdAsync(int id);
    }
}