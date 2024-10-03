using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;

namespace TraversalCore.WebUi.ViewComponents.DefaultComponents
{
    public class _DefaultDestinationsComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _DefaultDestinationsComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _destinationService.TGetListAll();
            return View(value);
        }
    }
}
