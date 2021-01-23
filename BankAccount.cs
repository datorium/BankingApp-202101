using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp_202101
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; private set; }
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
            Console.WriteLine($"- account {this.Number} created on {this.DateCreated} belongs to {this.Owner} and has a balance of {this.Balance} {this.Currency}");
        }

        public void AddToBalance(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
