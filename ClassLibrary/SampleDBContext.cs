
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ClassLibrary
{
    public class SampleDBContext : DbContext
    {
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Bank> Banks => Set<Bank>();
        public DbSet<AutomatedTellerMachine> TellerMachines => Set<AutomatedTellerMachine>();
        public DbSet<Card> Cards => Set<Card>();
        public DbSet<Transaction> Transactions => Set<Transaction>();
        public SampleDBContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BankDB;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        public Bank GetBankForCard(Card card)
        {
            return Banks.SingleOrDefault(b => b.Cards.Contains(card));
        }
    }
}
