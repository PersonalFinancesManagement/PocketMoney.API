using System;
using System.Collections.Generic;
using System.Text;

namespace PocketMoney.Application.Interfaces
{
    public interface IAppSettings
    {
        string ConnectionString { get; set; }
    }
}
