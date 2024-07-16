using productAPI.DTO;
using productAPI.Model;

namespace productAPI.DTOConversion
{
    public static class ProductConversion
    {
        static public ProductDTO ToDTO(this Product product) => new ProductDTO
        (
            product.ID,
            product.Name,
            product.Description,
            product.Price
        );
        static public Product ToModel(this ProductDTO productDTO) => new Product
        (
            productDTO.ID,
            productDTO.Name,
            productDTO.Description,
            productDTO.Price
        );
    }
}
