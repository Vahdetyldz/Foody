using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.DefaultViewComponents
{
    public class _DeafultAboutSectionComponentPartial : ViewComponent
    {
        private readonly IAboutSevice _aboutSevice;

        public _DeafultAboutSectionComponentPartial(IAboutSevice aboutSevice)
        {
            _aboutSevice = aboutSevice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutSevice.TGetAll();
            return View(values);
        }
    }
}
