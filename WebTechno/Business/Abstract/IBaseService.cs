namespace WebTechno.Business.Abstract
{
    public interface IBaseService<RsDTO,T,RqDTO>
    {
        List<RsDTO> GetAll();
        RsDTO GetById(int id);
        void Insert(RqDTO dto);
        void Update(RqDTO dto);
        void Delete(int id);
    }
}
