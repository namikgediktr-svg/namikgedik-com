using Microsoft.AspNetCore.Mvc;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/articles")]
public sealed class ArticlesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var articles = new[]
        {
            new
            {
                id = 1,
                slug = "welcome-to-namikgedik",
                title = "Welcome to NamikGedik.com",
                language = "en",
                publishedAt = DateTime.UtcNow
            }
        };

        return Ok(articles);
    }
}
