using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.DefaultViewComponents
{
    public class _DeafultTestimonialSectionComponentPartial : ViewComponent
    {
        private readonly IReviewService _reviewService;

        public _DeafultTestimonialSectionComponentPartial(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _reviewService.TGetAll();
            return View(values);
        }
    }
}
