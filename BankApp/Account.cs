using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// Class that defines a bank account
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Get/Set Account Number property
        /// </summary>
        public int AccountNumber { get; private set; }
        public decimal AccountBalance { get; set; }
        public string EmailAddress { get; set; }
        public string AccountType { get; set; }
        public DateTime CreateDate { get; set; }
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
