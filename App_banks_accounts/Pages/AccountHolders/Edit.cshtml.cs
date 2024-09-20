using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App_banks_accounts.Data;
using App_banks_accounts.Models;

namespace App_banks_accounts.Pages.AccountHolders
{
    public class EditModel : PageModel
    {
        private readonly App_banks_accounts.Data.App_banks_accountsContext _context;

        public EditModel(App_banks_accounts.Data.App_banks_accountsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder =  await _context.AccountHolder.FirstOrDefaultAsync(m => m.AccountHolderId == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            AccountHolder = accountholder;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AccountHolder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountHolderExists(AccountHolder.AccountHolderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AccountHolderExists(int id)
        {
            return _context.AccountHolder.Any(e => e.AccountHolderId == id);
        }
    }
}
