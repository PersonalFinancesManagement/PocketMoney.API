namespace PocketMoney.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public double Balance { get; private set; }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
