using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
