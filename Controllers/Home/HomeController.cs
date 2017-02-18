using Microsoft.AspNetCore.Mvc;

namespace EmptyWeb.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.Home.HomeModel();
            return View(model);
        }
    }
}