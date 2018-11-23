using MediatR;
using PocketMoney.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PocketMoney.Application.User.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly ISqlConn _sqlConn;

        public CreateUserCommandHandler(ISqlConn sqlConn)
        {
            _sqlConn = sqlConn;
        }

        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _sqlConn
        }
    }
}
