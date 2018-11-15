using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PocketMoney.Data.DataAccess
{
    public class UserData
    {
        private readonly string connectionString;
        private readonly string schema;
        public UserData(string conn)
        {
            connectionString = conn;
            schema = "development";
        }
        public object GetUserInfo(int ID)
        {
            using (IDbConnection conn = new NpgsqlConnection(connectionString))
            {
                return conn.Query(
                    $@"SELECT name, age, email, lastlogin FROM {schema}.user WHERE id=@id",new {id = ID}
                );
            }
        }
    }
}
