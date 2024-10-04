using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.NewUILayoutComponents
{
    public class _NewUILayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
