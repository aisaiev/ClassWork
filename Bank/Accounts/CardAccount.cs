﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CardAccount : BankAccount, IInterest, IAmountChangeble
    {
        public decimal InterestRate { get; set; }

        public CardAccount(decimal balance, string owner)
            : base(balance, owner)
        {
            this.InterestRate = 0.1m;
        }

        public void SetInterestRate(decimal interestRate)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            this.Balance += this.Balance * this.InterestRate;
        }

        public void PutAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public void TakeAmount(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
