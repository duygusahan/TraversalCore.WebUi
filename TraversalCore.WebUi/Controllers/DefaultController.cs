using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
