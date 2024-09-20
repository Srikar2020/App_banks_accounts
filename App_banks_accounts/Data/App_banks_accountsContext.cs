using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App_banks_accounts.Models;

namespace App_banks_accounts.Data
{
    public class App_banks_accountsContext : DbContext
    {
        public App_banks_accountsContext (DbContextOptions<App_banks_accountsContext> options)
            : base(options)
        {
        }

        public DbSet<App_banks_accounts.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<App_banks_accounts.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
