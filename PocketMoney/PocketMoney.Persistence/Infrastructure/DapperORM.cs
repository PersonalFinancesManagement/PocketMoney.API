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

        public int Execute(string sql, object param = null, IDbTransaction transaction = null)
        {
            using (IDbConnection conn = new Npgsql.NpgsqlConnection(_appSettings.ConnectionString))
            {
                conn.Open();

                if(transaction == null)
                {
                    using (var trans = conn.BeginTransaction())
                    {
                        var AffectedRows = conn.Execute(sql, param, trans);

                        trans.Commit();

                        return AffectedRows;
                    }    
                }
                else
                {
                    using (transaction)
                    {
                        var AffectedRows = conn.Execute(sql, param, transaction);

                        transaction.Commit();

                        return AffectedRows;
                    }
                }
            }
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
