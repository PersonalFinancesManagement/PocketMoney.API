using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using PocketMoney.Application.Repositories;
using PocketMoney.Application.User.Commands;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Persistence.Repositories {
    public class UserRepository : IUserRepository {

        public UserRepository (IConfiguration config)
        {
            _config = config;
            _databaseSchema = _config.GetSection("DatabaseSettings:schema").Value;
        }

        private readonly IConfiguration _config;

        private readonly string _databaseSchema;

        public IDbConnection Connection {
            get
            {
                return new Npgsql.NpgsqlConnection (_config.GetSection("DatabaseSettings:postgres11").Value);
            }
        }

        public async Task CreateUserAsync (UserModel user) {
            var sql = @"INSERT INTO Development.user(name, email, password) VALUES (@name, @email, @password)";

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
            var sql = $@"SELECT name, email FROM {_databaseSchema}.users WHERE id = @id";

            using (IDbConnection conn = Connection)
            {
                conn.Open();

                return await conn.QueryFirstOrDefaultAsync(sql, new {id = id});
            }
        }
    }
}