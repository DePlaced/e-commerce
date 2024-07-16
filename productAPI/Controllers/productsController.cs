using Microsoft.AspNetCore.Mvc;
using productAPI.BusinessLogic;
using productAPI.DTO;

namespace productAPI.Controllers;

[ApiController]
[Route("products")]
public class productsController : AppController
{

    private readonly ILogger<productsController> _logger;
    private readonly IProductLogic _productLogic;

    public productsController(ILogger<productsController> logger, IProductLogic productLogic)
    {
        _logger = logger;
        _productLogic = productLogic;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return await GetResultWithErrorHandling(Request, async () =>
        {
            return Ok(await _productLogic.GetAll());
        });
    }
}
