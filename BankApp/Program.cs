using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();
            myAccount.AccountNumber = 12345;
            myAccount.AccountName = "My Checking";
            myAccount.AccountBalance = 10000000M;

        }
    }
}
