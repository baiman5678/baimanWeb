using Microsoft.AspNetCore.Mvc;

namespace bobproject.Controllers
{
    public class RiderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
