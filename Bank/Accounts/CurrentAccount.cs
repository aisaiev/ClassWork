using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class CurrentAccount : BankAccount, IAmountChangeble
    {
        public CurrentAccount(decimal balance, string owner)
            : base(balance, owner)
        {
        }

        public void PutAmount(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void TakeAmount(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
