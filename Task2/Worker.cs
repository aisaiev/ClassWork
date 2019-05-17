using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Worker
    {
        public void Pour(Plant plant)
        {
            plant.FluidIntake();
        }

        public void Feed(Plant plant)
        {
            plant.MineralConsumption();
        }

        public void PourAndFeed(Plant plant)
        {
            plant.FluidIntakeAndMineralConsumption();
        }
    }
}
