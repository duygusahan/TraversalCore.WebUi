using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.NewUILayoutComponents
{
    public class _NewUILayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
