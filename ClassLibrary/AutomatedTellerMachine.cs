﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutomatedTellerMachine
    {
        [Key]
        public int Id { get; set; }
        public string? Adress { get; set; }
        public decimal Balance { get; set; }
        public AutomatedTellerMachine()
        {
            Adress = string.Empty;
            Balance = 0;
        }
    }
}
