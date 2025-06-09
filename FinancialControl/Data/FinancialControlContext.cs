using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinancialControl.Models;

namespace FinancialControl.Data
{
    public class FinancialControlContext : DbContext
    {
        public FinancialControlContext (DbContextOptions<FinancialControlContext> options)
            : base(options)
        {
        }

        public DbSet<FinancialControl.Models.Transacao> Transacao { get; set; } = default!;
    }
}
