using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.DefaultViewComponents
{
    public class _DefaultCarouselSectionComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultCarouselSectionComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _sliderService.TGetAll();
            return View(values);
        }
    }
}
