using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using App_banks_accounts.Data;
using App_banks_accounts.Models;

namespace App_banks_accounts.Pages.AccountHolders
{
    public class DetailsModel : PageModel
    {
        private readonly App_banks_accounts.Data.App_banks_accountsContext _context;

        public DetailsModel(App_banks_accounts.Data.App_banks_accountsContext context)
        {
            _context = context;
        }

        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.AccountHolderId == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            else
            {
                AccountHolder = accountholder;
            }
            return Page();
        }
    }
}
