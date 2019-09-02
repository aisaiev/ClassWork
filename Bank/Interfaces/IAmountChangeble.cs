using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IAmountChangeble
    {
        void PutAmount(decimal amount);

        void TakeAmount(decimal amount);
    }
}
