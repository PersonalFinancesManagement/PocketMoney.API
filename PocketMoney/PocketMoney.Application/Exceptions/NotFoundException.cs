using System;

namespace PocketMoney.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key, object value)
            : base($"Entity \"{name}\" ({key}) with value {value} was not found.")
        {
        }
    }
}