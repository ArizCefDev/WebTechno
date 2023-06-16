using WebTechno.DTO;
using WebTechno.Models;

namespace WebTechno.Business.Abstract
{
    public interface ITechnologyService
        :IBaseService<TechnologyDTO, Technology, TechnologyDTO>
    {
    }
}
