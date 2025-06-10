using FinancialControl.Data;
using FinancialControl.Models;
using Microsoft.EntityFrameworkCore;

namespace Transacoes.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new FinancialControlContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FinancialControlContext>>()))
        {
            if (context == null || context.Transacao == null)
            {
                throw new ArgumentNullException("Null FinancialControl Context");
            }

           

            context.Transacao.AddRange(
                new Transacao {
                    Valor = 5,
                    ReleaseDate = DateTime.Parse("2025-2-12"),
                    nameBank = "Bradesco",
                    Descricao = "Comprar pão"
                },
                new Transacao {
                    Valor = 20000,
                    ReleaseDate = DateTime.Parse("2025-6-06"),
                    nameBank = "Itaú",
                    Descricao = "Pagar agiota"
                }
            );
            context.SaveChanges();
        }
    }
}