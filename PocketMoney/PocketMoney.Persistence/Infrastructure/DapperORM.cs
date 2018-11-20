using Dapper;
using PocketMoney.Application.Interfaces;
using PocketMoney.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PocketMoney.Persistence.Infrastructure
{
    public class DapperORM : ISqlConn
    {
        private readonly AppSettings _appSettings;

        public DapperORM(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public IEnumerable<dynamic> Query(string sql, object param = null, IDbTransaction transaction = null)
        {
            using(IDbConnection conn = new Npgsql.NpgsqlConnection(_appSettings.ConnectionString))
            {
                return conn.Query(sql, param, transaction);
            }
        }
    }
}
