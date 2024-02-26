using static AppControleFinanceiro.Models.Enums.Types;

namespace AppControleFinanceiro.Models.Entitys
{
    public class Transaction
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public TransactionType Type { get; set; }
        public DateTimeOffset Date { get; set; }

        public Transaction(int id, string name, decimal value, DateTimeOffset date)
        {
            Id = id;
            Name = name;
            Value = value;
            Date = date;
        }
    }
}
