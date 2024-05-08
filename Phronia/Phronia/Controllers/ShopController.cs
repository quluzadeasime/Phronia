using Microsoft.AspNetCore.Mvc;

namespace Phronia.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
