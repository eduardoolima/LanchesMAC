using LanchesMac.Areas.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LanchesMac.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminChartController : Controller
    {
        private readonly ChartSalesService _chartSales;

        public AdminChartController(ChartSalesService chartSales)
        {
            _chartSales = chartSales ?? throw
                new ArgumentNullException(nameof(chartSales));
        }

        public JsonResult SnackSales(int dias)
        {
            var lanchesVendasTotais = _chartSales.GetSnackSales(dias);
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MonthSales()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WeekSales()
        {
            return View();
        }
    }
}
