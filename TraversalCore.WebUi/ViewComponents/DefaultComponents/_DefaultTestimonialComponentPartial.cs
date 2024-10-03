using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;

namespace TraversalCore.WebUi.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _testimonialService.TGetListAll();
            return View(value);
        }
    }
}
