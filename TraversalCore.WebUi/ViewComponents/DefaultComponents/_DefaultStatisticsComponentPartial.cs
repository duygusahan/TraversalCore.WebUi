using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.DefaultComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
