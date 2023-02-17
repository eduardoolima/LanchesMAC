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

        public IActionResult Index()
        {
            //var snacks = _snackRepository.Snacks;
            //return View(snacks);
            SnackListViewModel snackListViewModel = new();
            snackListViewModel.Snacks = _snackRepository.Snacks;
            snackListViewModel.CurrentCategory = "Categoria atual";
            return View(snackListViewModel);
        }
    }
}
