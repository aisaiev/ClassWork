using ClassWork.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Fridge
    {
        public FridgeState FridgeState { get; private set; }

        public MainDoorState MainDoorState { get; private set; }

        public SecondaryDoorState SecondaryDoorState { get; private set; }

        public event EventHandler<FridgeEventArgs> FridgeEvent;

        public void OnChangeFridgeState()
        {
            if (this.FridgeState == FridgeState.OFF)
            {
                this.FridgeState = FridgeState.ON;
            }
            else
            {
                this.FridgeState = FridgeState.OFF;
            }
            this.FridgeEvent?.Invoke(this, new FridgeEventArgs(this.GetFridgeState()));
            this.FridgeEvent?.Invoke(this, new FridgeEventArgs(this.GetSummaryFridgeState()));
        }

        public void OnChangeMainDoorState()
        {
            if (this.MainDoorState == MainDoorState.CLOSED)
            {
                this.MainDoorState = MainDoorState.OPENED;
            }
            else
            {
                this.MainDoorState = MainDoorState.CLOSED;
            }
            this.FridgeEvent?.Invoke(this, new FridgeEventArgs(this.GetFridgeMainDoorState()));
            this.FridgeEvent?.Invoke(this, new FridgeEventArgs(this.GetSummaryFridgeState()));
        }

        public void OnChangeSecondaryDoorState()
        {
            if (this.SecondaryDoorState == SecondaryDoorState.CLOSED)
            {
                this.SecondaryDoorState = SecondaryDoorState.OPENED;
            }
            else
            {
                this.SecondaryDoorState = SecondaryDoorState.CLOSED;
            }
            this.FridgeEvent(this, new FridgeEventArgs(this.GetFridgeSecondaryDoorState()));
            this.FridgeEvent?.Invoke(this, new FridgeEventArgs(this.GetSummaryFridgeState()));
        }

        private string GetFridgeState()
        {
            return $"FridgeState: {this.FridgeState}";
        }

        private string GetFridgeMainDoorState()
        {
            return $"MainDoorState: {this.MainDoorState}";
        }

        private string GetFridgeSecondaryDoorState()
        {
            return $"MainDoorState: {this.SecondaryDoorState}";
        }

        private string GetSummaryFridgeState()
        {
            return $"FridgeState: {this.FridgeState} MainDoorState: {this.MainDoorState} SecondaryDoorState: {this.SecondaryDoorState}";
        }

        public void PrintFridgeState(object sender, FridgeEventArgs e)
        {
            Console.WriteLine(e.State);
        }
    }
}
