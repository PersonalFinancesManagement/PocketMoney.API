using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PocketMoney.Persistence
{
    public class teste
    {
        public teste()
        {
            using(IDbConnection conn = new Npgsql.NpgsqlConnection("bla"))
            {
                conn.Query()
            }
        }
    }
}
