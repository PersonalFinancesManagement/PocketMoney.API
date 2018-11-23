using PocketMoney.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketMoney.Persistence.Configurations
{
    public class AppSettings : IAppSettings
    {
        public string ConnectionString { get; set; }
    }
}
