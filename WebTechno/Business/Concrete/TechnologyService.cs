using AutoMapper;
using WebTechno.Business.Abstract;
using WebTechno.DTO;
using WebTechno.Models;
using WebTechno.Models.Context;

namespace WebTechno.Business.Concrete
{
    public class TechnologyService : BaseService<TechnologyDTO, Technology, TechnologyDTO>,ITechnologyService
    {
        public TechnologyService(IMapper mapper, AppDbContext dbContext) : base(mapper, dbContext)
        {
        }
    }
}
