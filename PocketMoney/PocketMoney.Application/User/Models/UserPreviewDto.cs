using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using PocketMoney.Domain.Entities;

namespace PocketMoney.Application.User.Models
{
    public class UserPreviewDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public static Expression<Func<User, UserPreviewDto>> Projection
        {
            get
            {
                return c => new UserPreviewDto
                {
                    UserId = c.UserId,
                    Email = c.Email
                };
            }
        }
    }
}
