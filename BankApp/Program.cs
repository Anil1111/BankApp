using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"Account Number: {myAccount.AccountNumber} |" +
            //    $" Account Type: {myAccount.AccountType} |"+
            //    $" Account Name: {myAccount.AccountName} |" +
            //    $" Email: {myAccount.EmailAddress} |" +
            //    $" Balance: {myAccount.AccountBalance:C}");

            Console.WriteLine("Welcome to the Banking Application");
            while (true)
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Create New Account");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Print All Accounts");

                Console.Write("Select Option: ");
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "0":
                        Console.WriteLine("Thank you for using our banking application!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var email = Console.ReadLine();
                        Console.Write("Account Name: ");
                        var accountName = Console.ReadLine();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
