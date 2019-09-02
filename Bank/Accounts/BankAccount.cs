using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public string Owner { get; set; }

        public BankAccount(decimal balance, string owner)
        {
            this.Balance = balance;
            this.Owner = owner;
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }

        public string GetOwner()
        {
            return this.Owner;
        }

        public decimal CloseAccount()
        {
            decimal amount = this.GetBalance();
            this.Balance = 0;
            return amount;
        }
    }
}
