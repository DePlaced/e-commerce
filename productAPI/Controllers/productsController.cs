using Microsoft.AspNetCore.Mvc;
using productAPI.BusinessLogic;
using productAPI.DTO;

namespace productAPI.Controllers;

[ApiController]
[Route("products")]
public class productsController : ControllerBase
{

    private readonly ILogger<productsController> _logger;
    private readonly IProductLogic _productLogic;

    public productsController(ILogger<productsController> logger, IProductLogic productLogic)
    {
        _logger = logger;
        _productLogic = productLogic;
    }

    [HttpGet]
    public async ActionResult<IEnumerable<ProductDTO>> Get()
    {
        return null;
    }
}
