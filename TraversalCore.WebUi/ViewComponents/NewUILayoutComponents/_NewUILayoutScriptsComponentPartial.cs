using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.NewUILayoutComponents
{
    public class _NewUILayoutScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
