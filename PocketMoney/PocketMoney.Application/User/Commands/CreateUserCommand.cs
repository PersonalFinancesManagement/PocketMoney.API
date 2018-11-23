using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketMoney.Application.User.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
