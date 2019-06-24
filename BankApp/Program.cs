using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Welcome to the Banking Application");
            while (true)
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Create New Account");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Print All Accounts");
                Console.WriteLine("5 - Print All Transactions");

                Console.Write("Select Option: ");
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "0":
                        Console.WriteLine("Thank you for using our banking application!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        Console.Write("Account Name: ");
                        var accountName = Console.ReadLine();

                        Console.WriteLine("Select Account Type:");
                        var accountTypes = Enum.GetNames(typeof(AccountTypes));
                        for(int i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"\t{i} - {accountTypes[i]}");
                        }
                        var accountType = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Initial Deposit: ");
                        var initialDeposit = Convert.ToDecimal(Console.ReadLine());

                        var myAccount = Bank.CreateAccount(emailAddress, accountName, (AccountTypes)accountType, initialDeposit);

                        Console.WriteLine($"Account Number: {myAccount.AccountNumber} |" +
                            $" Account Name: {myAccount.AccountName} |" +
                            $" Account Type: {myAccount.AccountType} |" +
                            $" Email: {myAccount.EmailAddress} |" +
                            $" Balance: {myAccount.AccountBalance:C}");
                        break;
                    case "2":
                        //Deposit
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        var accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ammount to Deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(accountNumber, amount);
                        Console.WriteLine("Deposit Successful");
                        break;
                    case "3":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ammount to Withdraw: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Withdraw(accountNumber, amount);
                        Console.WriteLine("Deposit Successful");
                        break;
                    case "4":
                        //Print all accounts
                        PrintAllAccounts();
                        break;
                    case "5":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        var transactions = Bank.GetTransactionsByAccountNumber(accountNumber);
                        foreach (var transaction in transactions)
                        {
                            Console.WriteLine($"Trans Type: {transaction.TransactionType} | Trans Date: {transaction.TransactionDate} | Trans Amount {transaction.Amount:C}");
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        private static void PrintAllAccounts()
        {
            Console.Write("Email Address: ");
            var emailAddress = Console.ReadLine();
            var accounts = Bank.GetAllAccountsByEmailAddress(emailAddress);
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber} |" +
                $" Account Name: {account.AccountName} |" +
                $" Account Type: {account.AccountType} |" +
                $" Email: {account.EmailAddress} |" +
                $" Balance: {account.AccountBalance:C}");
            }
        }
    }
}
