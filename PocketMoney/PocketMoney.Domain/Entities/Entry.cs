using System;
using PocketMoney.Domain.Enumerations;

namespace PocketMoney.Domain.Entities
{
    public class Entry
    {
        public int Id { get; set; }
        public EntryType Type { get; private set; }
        public double Value { get; private set; }
        public DateTime Date { get; private set; }
        public EntryCategory Category { get; set; }

        public Entry(EntryType type, double value, DateTime date, EntryCategory category = EntryCategory.Others)
        {
            Type = type;
            Value = value;
            Date = date;
            Category = category;
        }
    }
}
