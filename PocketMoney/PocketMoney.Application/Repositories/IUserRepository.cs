using System.Threading.Tasks;

namespace PocketMoney.Application.Repositories {
    public interface IUserRepository {
        Task CreateUserAsync (Domain.Entities.User user);
        Task<object> GetUserByIdAsync(int id);
    }
}