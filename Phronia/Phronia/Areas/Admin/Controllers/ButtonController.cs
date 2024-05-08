using Microsoft.AspNetCore.Mvc;

namespace Phronia.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ButtonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
