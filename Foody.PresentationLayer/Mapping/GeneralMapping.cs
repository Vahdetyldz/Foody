using AutoMapper;
using Foody.DtoLayer.Dtos.AboutDtos;
using Foody.DtoLayer.Dtos.SlidetDtos;
using Foody.EntityLayer.Concrete;

namespace Foody.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto, About>().ReverseMap();

            CreateMap<ResultSliderDto, Slider>().ReverseMap();
            CreateMap<CreateSliderDto, Slider>().ReverseMap();
            CreateMap<UpdateSilderDto, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto, Slider>().ReverseMap();

        }
    }
}
