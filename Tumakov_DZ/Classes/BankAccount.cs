using System;
using System.Collections.Generic;
using System.IO;

namespace Tumakov_DZ
{
    public class BankAccount
    {
        private Guid accountNumber;
        private string accountType;
        private string accountHolder;
        private decimal balance;
        private Queue<BankTransaction> transactionsQueue;
        public Guid AccountNumber
        {
            get
            {
                return AccountNumber;
            }
        }
        public string AccountType
        {
            get
            {
                return accountType;
            }
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
        public string AccountHolder
        {
            get
            {
                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }
        public Queue<BankTransaction> TransactionsQueue => transactionsQueue;
        public BankAccount(string holderName, decimal initialBalance, string type)
        {
            accountNumber = Guid.NewGuid();  
            accountHolder = holderName;
            balance = initialBalance;
            accountType = type;
            transactionsQueue = new Queue<BankTransaction>();
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                var transaction = new BankTransaction(amount, DateTime.Now);
                transactionsQueue.Enqueue(transaction);
                Console.WriteLine($"Счет {accountNumber}: Пополнен на {amount}. Новый баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть больше 0.");
            }
        }


        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                var transaction = new BankTransaction(-amount, DateTime.Now);
                transactionsQueue.Enqueue(transaction);
                Console.WriteLine($"Счет {accountNumber}: Снято {-amount}. Новый баланс: {balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств для снятия.");
            }
            else
            {
                Console.WriteLine("Сумма снятия должна быть больше 0.");
            }
        }
        public void DumpToScreen()
        {
            Console.WriteLine($"Счет №{accountNumber}, Тип: {accountType}, Владелец: {accountHolder}, Баланс: {balance}");
        }
    }
}
