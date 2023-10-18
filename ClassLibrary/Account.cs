using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Account:Person
    {
        public List<Card>? Cards { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public Account():base()
        {
            Email=string.Empty;
            Password=string.Empty;
            Role="ROLE_USER";
        }
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
