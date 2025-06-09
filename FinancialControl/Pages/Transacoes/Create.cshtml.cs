using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinancialControl.Data;
using FinancialControl.Models;

namespace FinancialControl.Pages.Transacoes
{
    public class CreateModel : PageModel
    {
        private readonly FinancialControl.Data.FinancialControlContext _context;

        public CreateModel(FinancialControl.Data.FinancialControlContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Transacao Transacao { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Transacao.Add(Transacao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
