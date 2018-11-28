using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace PocketMoney.Application.User.Commands {
    public class CreateUserCommand : IRequest {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }

}