using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISnackRepository _snackRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISnackRepository snackRepository, ShoppingCart shoppingCart)
        {
            _snackRepository = snackRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var itens = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = itens;

            var shoppingCartVM = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartVM);
        }

        public IActionResult AddItemToShoppingCart(int snackId)
        {
            var selectedSnack = _snackRepository.Snacks.FirstOrDefault(s => s.Id == snackId);

            if(selectedSnack != null)
            {
                _shoppingCart.AddToShoppingCart(selectedSnack);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveItemFromShoppingCart(int snackId)
        {
            var selectedSnack = _snackRepository.Snacks.FirstOrDefault(s => s.Id == snackId);

            if (selectedSnack != null)
            {
                _shoppingCart.RemoveFromShoppingCart(selectedSnack);
            }
            return RedirectToAction("Index");
        }
    }
}
