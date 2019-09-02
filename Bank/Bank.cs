using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public List<BankAccount> BankAccounts { get; set; }

        public void CreateAccount(AccountType accountType, decimal balance, string owner)
        {
            BankAccount bankAccount = null;
            switch (accountType)
            {
                case AccountType.CurrentAccount:
                    bankAccount = new CurrentAccount(balance, owner);
                    break;
                case AccountType.CardAccount:
                    bankAccount = new CardAccount(balance, owner);
                    break;
                case AccountType.DepositAccount:
                    bankAccount = new DepositAccount(balance, owner);
                    break;
            }
            this.BankAccounts.Add(bankAccount);
        }

        public void PutAmount(decimal amount, string owner)
        {
            foreach (var bankAccount in this.BankAccounts)
            {
                if (bankAccount.Owner == owner)
                {
                    bankAccount.Balance += amount;
                }
            }
        }

        public void TakeAmount(decimal amount, string owner)
        {
            foreach (var bankAccount in this.BankAccounts)
            {
                if (bankAccount.Owner == owner)
                {
                    bankAccount.Balance -= amount;
                }
            }
        }

        public void UpdateBalanceWithInterest(string owner)
        {
            foreach (var bankAccount in this.BankAccounts)
            {
                if (bankAccount.Owner == owner)
                {
                    if (bankAccount is IInterest account)
                    {
                        account.UpdateBalance();
                    }
                }
            }
        }

        public void SetInterestRate(string owner, decimal interestRate)
        {
            foreach (var bankAccount in this.BankAccounts)
            {
                if (bankAccount.Owner == owner)
                {
                    if (bankAccount is DepositAccount depositAccount)
                    {
                        depositAccount = (DepositAccount)bankAccount;
                        depositAccount.InterestRate = interestRate;
                    }
                    if (bankAccount is CardAccount cardAccount)
                    {
                        cardAccount = (CardAccount)bankAccount;
                        cardAccount.InterestRate = interestRate;
                    }
                }
            }
        }

        public decimal GetBalance(string owner)
        {
            foreach (var bankAccount in this.BankAccounts)
            {
                if (bankAccount.Owner == owner)
                {
                    return bankAccount.Balance;
                }
            }
            return 0;
        }

        public decimal CloseAccount(string owner)
        {
            foreach (var bankAccount in this.BankAccounts)
            {
                if (bankAccount.Owner == owner)
                {
                    bankAccount.CloseAccount();
                }
            }
            return 0;
        }
    }
}
