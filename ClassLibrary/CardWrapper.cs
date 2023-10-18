using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CardWrapper
    {
        public Card Card { get; private set; }
        public Bank Bank;
        public string getBank()
        {
            return Bank.Name;
        }

        public string DisplayName => $"Card Number: {Card.CardNumber} Balance: {Card.Balance}, Bank: {Bank.Name}";

        public CardWrapper(Card card, Bank bank)
        {
            Card = card;
            Bank = bank;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
