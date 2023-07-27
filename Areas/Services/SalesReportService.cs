using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Areas.Services
{
    public class SalesReportService
    {
        private readonly AppDbContext context;
        public SalesReportService(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Order>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in context.Orders select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.OrderDispatched >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.OrderDispatched <= maxDate.Value);
            }

            return await result
                         .Include(l => l.OrderItens)
                         .ThenInclude(l => l.Snack)
                         .OrderByDescending(x => x.OrderDispatched)
                         .ToListAsync();
        }
    }
}
