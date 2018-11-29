using System;
using System.Collections.Generic;
using System.Text;
using PocketMoney.Domain.Infrastructure;

namespace PocketMoney.Domain.ValueObjects
{
    public class Password : ValueObject
    {
        private readonly string HashString;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return HashString;
        }
    }
}
