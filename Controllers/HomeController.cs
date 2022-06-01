using Microsoft.AspNetCore.Mvc;

namespace ViewBag_ViewData__TempData.Controllers
{
    public class HomeController:Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
