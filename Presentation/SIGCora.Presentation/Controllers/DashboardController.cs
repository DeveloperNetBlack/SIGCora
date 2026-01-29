using Microsoft.AspNetCore.Mvc;

namespace SIGCora.Presentation.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
