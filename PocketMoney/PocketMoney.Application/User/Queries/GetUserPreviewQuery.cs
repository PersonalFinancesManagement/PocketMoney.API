using MediatR;
using PocketMoney.Application.User.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketMoney.Application.User.Queries
{
    public class GetUserPreviewQuery : IRequest<List<UserPreviewDto>>
    {
        public int UserId { get; set; }
    }
}
