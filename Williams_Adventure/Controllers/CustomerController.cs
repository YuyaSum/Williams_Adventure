using Microsoft.AspNetCore.Mvc;

namespace Williams_Adventure.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
