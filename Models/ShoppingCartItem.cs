using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Snack Snack { get; set; }
        public int Amount { get; set; }
        [StringLength(200)]
        public string ShoppingCartId { get; set; }
    }
}
