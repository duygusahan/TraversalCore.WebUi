using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.WebUi.ViewComponents.NewUILayoutComponents
{
    public class _NewUILayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
