using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinancialControl.Data;
using FinancialControl.Models;

namespace FinancialControl.Pages.Transacoes
{
    public class DeleteModel : PageModel
    {
        private readonly FinancialControl.Data.FinancialControlContext _context;

        public DeleteModel(FinancialControl.Data.FinancialControlContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Transacao Transacao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacao.FirstOrDefaultAsync(m => m.Id == id);

            if (transacao == null)
            {
                return NotFound();
            }
            else
            {
                Transacao = transacao;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacao.FindAsync(id);
            if (transacao != null)
            {
                Transacao = transacao;
                _context.Transacao.Remove(Transacao);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
