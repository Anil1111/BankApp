using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum AccountTypes
    {
        Checking,
        Savings,
        CD,
        Loan
    }


    /// <summary>
    /// Class that defines a bank account
    /// </summary>
    class Account
    {
        private static int lastAccountNumber = 0;

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreateDate = DateTime.Now;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Get/Set Account Number property
        /// </summary>
        public int AccountNumber { get; private set; }
        public decimal AccountBalance { get; private set; }
        public string EmailAddress { get; set; }
        public AccountTypes AccountType { get; set; }
        public DateTime CreateDate { get; private set; }
        public string AccountName { get; set; }
        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            AccountBalance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            AccountBalance -= amount;

            return AccountBalance;
        }

        #endregion
    }
}
