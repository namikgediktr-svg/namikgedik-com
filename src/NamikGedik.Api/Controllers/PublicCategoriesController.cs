using Microsoft.AspNetCore.Mvc;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/categories")]
public sealed class PublicCategoriesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var categories = new[]
        {
            new
            {
                id = 1,
                slug = "technology",
                title = "Technology",
                isActive = true
            }
        };

        return Ok(categories);
    }
}
