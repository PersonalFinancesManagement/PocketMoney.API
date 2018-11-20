using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PocketMoney.Application.Interfaces
{
    public interface ISqlConn
    {
        IEnumerable<dynamic> Query(string sql, object param = null, IDbTransaction transaction = null);
    }
}
