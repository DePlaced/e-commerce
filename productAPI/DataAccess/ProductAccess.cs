using productAPI.Model;

namespace productAPI.DataAccess
{
    public class ProductAccess : IProductAccess
    {
        public async Task<IEnumerable<Product>> GetAll()
        {
            return new List<Product>
            {
                new Product("1", "Product 1", "Description 1", 100),
                new Product("2", "Product 2", "Description 2", 200),
                new Product("3", "Product 3", "Description 3", 300),
                new Product("4", "Product 4", "Description 4", 400),
                new Product("5", "Product 5", "Description 5", 500)
            };
        }
    }
}
