using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IInterest
    {
        void UpdateBalance();

        void SetInterestRate(decimal interestRate);
    }
}
