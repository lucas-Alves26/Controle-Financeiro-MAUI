using System.Transactions;

namespace AppControleFinanceiro.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public List<Transaction>? GetAll()
        {
            return null;
        }

        public void Add(Transaction transaction)
        {
        }
        public void Update(Transaction transaction)
        {
        }
        public void Delete(Transaction transaction)
        {
        }
    }
}
