using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MVC_Globalization.Models;
using MVC_Globalization.Resources;
using System.Diagnostics;

namespace MVC_Globalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<SharedResource> _localizer;

        public HomeController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hondo()
        {
            return Ok(_localizer["Hello"].Value);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
