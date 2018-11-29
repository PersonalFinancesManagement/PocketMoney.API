using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using PocketMoney.Application.Repositories;

namespace PocketMoney.Persistence.Repositories
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(IConfiguration config) : base(config)
        {
        }

        public async Task<object> GetAccountByIdAsync(int id)
        {
            var sql = $"SELECT name, balance FROM \"{_databaseSchema}\".accounts WHERE id = @id";

            using (IDbConnection conn = Connection)
            {
                conn.Open();

                return await conn.QueryFirstOrDefaultAsync(sql, new {id = id});
            }
        }
    }
}