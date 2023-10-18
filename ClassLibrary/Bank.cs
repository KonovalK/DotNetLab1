using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public List<AutomatedTellerMachine>? Tellers { get; set; }
        public List<Card>? Cards { get; set; }

        public Bank () {
            Name = string.Empty;
            Adress = string.Empty;
            Tellers = new List<AutomatedTellerMachine>();
            Cards = new List<Card>();
        }

        public void AddTellerMachine(AutomatedTellerMachine machine)
        {
            Tellers.Add(machine);
        }
    }
}
