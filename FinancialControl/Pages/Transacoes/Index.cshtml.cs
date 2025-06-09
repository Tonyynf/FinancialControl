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
    public class IndexModel : PageModel
    {
        private readonly FinancialControl.Data.FinancialControlContext _context;

        public IndexModel(FinancialControl.Data.FinancialControlContext context)
        {
            _context = context;
        }

        public IList<Transacao> Transacao { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Transacao = await _context.Transacao.ToListAsync();
        }
    }
}
