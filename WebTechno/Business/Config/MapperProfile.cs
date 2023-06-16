using AutoMapper;
using WebTechno.DTO;
using WebTechno.Models;

namespace WebTechno.Business.Config
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Technology, TechnologyDTO>();
            CreateMap<TechnologyDTO, Technology>();
        }
    }
}
