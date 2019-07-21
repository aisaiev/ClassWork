using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2_13_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabit rabit = new Rabit();
            Hunter hunter = new Hunter();
            rabit.MoveEvent += hunter.Rabit_MoveEvent;

            rabit.Move();
            Thread.Sleep(1000);
            rabit.Move();
        }
    }
}
