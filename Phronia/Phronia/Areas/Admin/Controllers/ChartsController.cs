using Microsoft.AspNetCore.Mvc;

namespace Phronia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
