using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class SnackController : Controller
    {
        private readonly ISnackRepository _snackRepository;

        public SnackController(ISnackRepository snackRepository)
        {
            _snackRepository = snackRepository;
        }

        public IActionResult Index(string category)
        {
            IEnumerable<Snack> snacks;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                snacks = _snackRepository.Snacks.OrderBy(s => s.Id);
                currentCategory = "Todos os Lanches";
            }
            else
            {
                snacks = _snackRepository.Snacks.Where(s => s.Category.Name.Equals(category)).OrderBy(c => c.Name);
                currentCategory = category;
            }

            SnackListViewModel snackListViewModel = new();
            snackListViewModel.Snacks = snacks;
            snackListViewModel.CurrentCategory = currentCategory;
            return View(snackListViewModel);
        }

        public IActionResult Details(int id)
        {
            var snack = _snackRepository.Snacks.FirstOrDefault(s => s.Id == id);
            return View(snack);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Snack> snacks;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(searchString))
            {
                snacks = _snackRepository.Snacks.OrderBy(s => s.Id);
                currentCategory = "Todos os Lanches";

            }
            else
            {
                snacks = _snackRepository.Snacks.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
                if (snacks.Any())
                {
                    currentCategory = "Lanches";
                }
                else
                {
                    currentCategory = "Nenhum Lanche encontrado";
                }
            }
            return View("~/Views/Snack/Index.cshtml", new SnackListViewModel
            {
                Snacks = snacks,
                CurrentCategory = currentCategory
            });
        }
    }
}
