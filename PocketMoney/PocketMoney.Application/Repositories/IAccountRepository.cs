using System.Threading.Tasks;

namespace PocketMoney.Application.Repositories
{
    public interface IAccountRepository
    {
        Task<object> GetAccountByIdAsync(int id);
    }
}