using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace PocketMoney.Persistence.Repositories
{
    public class BaseRepository
    {
        public BaseRepository (IConfiguration config)
        {
            _config = config;
            _databaseSchema = _config.GetSection("DatabaseSettings:schema").Value;
        }

        private readonly IConfiguration _config;

        protected readonly string _databaseSchema;

        protected IDbConnection Connection {
            get
            {
                return new NpgsqlConnection (_config.GetSection("DatabaseSettings:postgres11").Value);
            }
        }
    }
}