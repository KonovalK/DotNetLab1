using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Summa { get; set; }
        public Transaction()
        {
            From = string.Empty;
            To = string.Empty;
            Summa = 0;
        }
    }
}
