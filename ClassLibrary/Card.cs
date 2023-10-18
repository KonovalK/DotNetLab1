using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int CardNumber { get; set; }
        public int CardPin { get; set; }

        public Card()
        {
            CardNumber = GenerateRandomCardNumber();
            CardPin = GenerateRandomCardPin();
            Balance = 0;
        }

        private int GenerateRandomCardNumber()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999);
        }

        private int GenerateRandomCardPin()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
