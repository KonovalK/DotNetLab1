using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutomatedTellerMachineWrapper
    {
        public AutomatedTellerMachine ATM { get; private set; }

        public Bank Bank { get; private set; }

        public string DisplayName => $"ATM number: {ATM.Id} Bank: {Bank.Name} Balance: {ATM.Balance}";

        public AutomatedTellerMachineWrapper(AutomatedTellerMachine atm, Bank bank)
        {
            ATM = atm;
            Bank = bank;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
