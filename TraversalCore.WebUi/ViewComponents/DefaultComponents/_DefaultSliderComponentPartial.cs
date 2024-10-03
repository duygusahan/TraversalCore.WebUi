using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
