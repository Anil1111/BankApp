using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum TypeOfTransation
    {
        Credit,
        Debit
    }
    class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public TypeOfTransation TransactionType {get; set; }
        public int AccountNumber { get; set; }
        public virtual Account Account { get; set; }

    }
}
