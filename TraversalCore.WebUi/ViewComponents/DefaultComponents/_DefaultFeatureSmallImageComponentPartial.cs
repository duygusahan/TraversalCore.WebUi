using Microsoft.AspNetCore.Mvc;
using TraversalCore.BusinessLayer.Abstract;

namespace TraversalCore.WebUi.ViewComponents.DefaultComponents
{
    public class _DefaultFeatureSmallImageComponentPartial:ViewComponent
    {
        private readonly IFeatureSmallImagesService _featureSmallImagesService;

        public _DefaultFeatureSmallImageComponentPartial(IFeatureSmallImagesService featureSmallImagesService)
        {
            _featureSmallImagesService = featureSmallImagesService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _featureSmallImagesService.TGetListAll();
            return View(value);
        }
    }
}
