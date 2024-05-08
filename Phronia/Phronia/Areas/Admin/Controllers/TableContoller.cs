using Microsoft.AspNetCore.Mvc;

namespace Phronia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TableContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
