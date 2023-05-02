using LanchesMac.Models;

namespace LanchesMac.ViewModel
{
    public class OrderSnackViewModel
    {
        public Order Order { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
