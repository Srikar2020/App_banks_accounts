using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using App_banks_accounts.Data;
using App_banks_accounts.Models;

namespace App_banks_accounts.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly App_banks_accounts.Data.App_banks_accountsContext _context;

        public IndexModel(App_banks_accounts.Data.App_banks_accountsContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
        }
    }
}
