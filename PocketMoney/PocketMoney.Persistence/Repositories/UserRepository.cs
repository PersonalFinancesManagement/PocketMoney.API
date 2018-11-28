using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using PocketMoney.Application.User.Commands;
using PocketMoney.Domain.Entities;
using PocketMoney.Persistence.Infrastructure;

namespace PocketMoney.Persistence.Repositories {
    public class UserRepository : IUserRepository {

        public UserRepository (IConfiguration config) {
            _config = config;
        }

        public IConfiguration _config { get; }

        public IDbConnection Connection {
            get {
                return new Npgsql.NpgsqlConnection (_config.GetSection ("ConnectionString:postgres11").ToString ());
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
    }
}