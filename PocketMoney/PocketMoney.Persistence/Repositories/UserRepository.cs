using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PocketMoney.Application.Repositories;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Persistence.Repositories {
    public class UserRepository : BaseRepository, IUserRepository {
        
        public UserRepository(IConfiguration config) : base(config)
        {
        }

        public async Task CreateUserAsync (User user) {
            var sql = $"INSERT INTO \"{_databaseSchema}\".user(name, email, password) VALUES (@name, @email, @password)";

            using (IDbConnection conn = Connection) {
                conn.Open ();

                using (IDbTransaction trans = conn.BeginTransaction ()) {
                    var result = await conn.ExecuteAsync (sql, new {
                        name = user.Name,
                            email = user.Email,
                            password = user.Password
                    }, trans);
                    trans.Commit ();
                }

            }
        }

        public async Task<object> GetUserByIdAsync(int id)
        {
            //TODO get account ids and names and make HATEOAS
            var sql = $"SELECT name, email FROM \"{_databaseSchema}\".users WHERE id = @id";

            using (IDbConnection conn = Connection)
            {
                conn.Open();

                return await conn.QueryFirstOrDefaultAsync(sql, new {id = id});
            }
        }
    }
}