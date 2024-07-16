using productAPI.DTO;

namespace productAPI.BusinessLogic
{
    public interface IProductLogic
    {
        Task<IEnumerable<ProductDTO>> GetAll();
    }
}
