using Northwind.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

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
