using System;
using System.Collections.Generic;

namespace BankingApp_202101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome Digital Banking App***");

            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("BA123456789", "Anna Lopez", 5000, "EUR"));
            accounts.Add(new BankAccount("BA123456790", "John Salamander", 200, "USD"));
            accounts.Add(new BankAccount("BA123456791", "Jenifer Poles", 150000, "GBP"));

            foreach (var account in accounts)
            {
                account.Print();
            }
        }
    }

    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public string Currency { get; }
        public DateTime DateCreated { get; }

        public BankAccount(string number, string owner, decimal balance, string currency)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
            this.Currency = currency;
            this.DateCreated = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"Account {this.Number} created on {this.DateCreated} belongs to {this.Owner} and has a balance of {this.Balance.ToString()} {this.Currency}");
        }
    }
}
