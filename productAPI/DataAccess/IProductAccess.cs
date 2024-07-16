using productAPI.Model;

namespace productAPI.DataAccess
{
    public interface IProductAccess
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
