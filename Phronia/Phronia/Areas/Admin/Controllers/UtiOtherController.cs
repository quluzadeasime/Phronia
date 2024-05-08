using Microsoft.AspNetCore.Mvc;

namespace Phronia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UtiOtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
