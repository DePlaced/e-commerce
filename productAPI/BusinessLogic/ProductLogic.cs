using productAPI.DataAccess;
using productAPI.DTO;
using productAPI.DTOConversion;

namespace productAPI.BusinessLogic
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductAccess _productAccess;

        public ProductLogic(IProductAccess productAccess)
        {
            _productAccess = productAccess;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            return (await _productAccess.GetAll()).Select(p => p.ToDTO());
        }
    }
}
