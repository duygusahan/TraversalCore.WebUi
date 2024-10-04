using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;

namespace TraversalCore.WebUi.ViewComponents.DestinationComponents
{
    public class _DestinationComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _DestinationComponentPartial(IDestinationService destinationService)
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
