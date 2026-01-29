using Microsoft.AspNetCore.Mvc;

namespace SIGCora.Presentation.Areas.Security.Controllers
{
    [Area("Security")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View("UserIndex");
        }
    }
}
