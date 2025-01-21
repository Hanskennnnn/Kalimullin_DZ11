

namespace Tumakov_DZ
{
    public class BankTransaction
    {

        public decimal amount;     
        public DateTime transactionDate;
        public decimal Amount
        {
            get
            {
                return amount;
            }
        }
        public DateTime TransctionDate
        {
            get
            {
                return transactionDate;
            }
        }

        public BankTransaction(decimal amount, DateTime transactionDate)
        {
            this.amount = amount;
            this.transactionDate = transactionDate;
        }
    }
}