using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;

namespace TraversalCore.WebUi.ViewComponents.DefaultComponents
{
    public class _DefaultSubAboutComponentPartial:ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _DefaultSubAboutComponentPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _subAboutService.TGetListAll();
            return View(value);
        }
    }
}
