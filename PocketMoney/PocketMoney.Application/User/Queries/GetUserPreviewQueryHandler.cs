using MediatR;
using PocketMoney.Application.Interfaces;
using PocketMoney.Application.User.Models;
using PocketMoney.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PocketMoney.Application.User.Queries
{
    public class GetUserPreviewQueryHandler : IRequestHandler<GetUserPreviewQuery, List<UserPreviewDto>>
    {

        private readonly AppSettings _appsettings;
        private readonly ISqlConn _sqlConn;

        public GetUserPreviewQueryHandler(AppSettings appSettings, ISqlConn sqlConn)
        {
            _appsettings = appSettings;
            _sqlConn = sqlConn;
        }

        public Task<List<UserPreviewDto>> Handle(GetUserPreviewQuery request, CancellationToken cancellationToken)
        {
            _sqlConn.Query("teste");
        }
    }
}
