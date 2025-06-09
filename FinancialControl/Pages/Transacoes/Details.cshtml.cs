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
    public class DetailsModel : PageModel
    {
        private readonly FinancialControl.Data.FinancialControlContext _context;

        public DetailsModel(FinancialControl.Data.FinancialControlContext context)
        {
            _context = context;
        }

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
    }
}
