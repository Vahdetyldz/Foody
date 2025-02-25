using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Models.ViewComponents.DefaultViewComponents
{
    public class _DeafultFooterSectionComponentPartial : ViewComponent
    {
        private readonly IAdressService _adressService;

        public _DeafultFooterSectionComponentPartial(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _adressService.TGetAll();
            return View(values);
        }
    }
}
