using LanchesMac.Context;
using LanchesMac.Models;

namespace LanchesMac.Areas.Services
{
    public class ChartSalesService
    {
        private readonly AppDbContext context;
        public ChartSalesService(AppDbContext context)
        {
            this.context = context;
        }

        public List<SnackChart> GetSnackSales(int days = 360)
        {
            var data = DateTime.Now.AddDays(-days);

            var snacks = (from pd in context.OrderDetails
                           join l in context.Snacks on pd.Id equals l.Id
                           where pd.Order.OrderDispatched >= data
                           group pd by new { pd.Id, l.Name }
                           into g
                           select new
                           {
                               SnackName = g.Key.Name,
                               SnacksAmount = g.Sum(q => q.Amount),
                               SnacksTotalValue = g.Sum(a => a.Price * a.Amount)
                           });

            var list = new List<SnackChart>();

            foreach (var item in snacks)
            {
                var snack = new SnackChart();
                snack.SnackName = item.SnackName;
                snack.SnackAmount = item.SnacksAmount;
                snack.SnackTotalValue = item.SnacksTotalValue;
                list.Add(snack);
            }
            return list;
        }
    }
}
