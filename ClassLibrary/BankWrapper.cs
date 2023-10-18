using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BankWrapper
    {
        public Bank Bank { get; private set; }

        public string? DisplayName => Bank.Name;

        public BankWrapper(Bank bank)
        {
            Bank = bank;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
