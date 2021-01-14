using System;
using System.Collections.Generic;

namespace BankingApp_202101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome to my Banking App***");

            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("BA123456789", "Anna Lopez", 5000));
            accounts.Add(new BankAccount("BA123456790", "John Salamander", 200));
            accounts.Add(new BankAccount("BA123456791", "Jenifer Poles", 150000));           



        }
    }

    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }

        public BankAccount(string number, string owner, decimal balance)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
        }

        public void Print()
        {
            Console.WriteLine($"Account number {this.Number} belongs to {this.Owner} and has a balance of {this.Balance.ToString()} euros");
        }
    }
}
