using Microsoft.AspNetCore.Mvc;
using NamikGedik.Application.Contracts;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/management/articles")]
public sealed class ManagementArticlesController : ControllerBase
{
    private readonly IArticleService _articleService;

    public ManagementArticlesController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var articles = await _articleService.GetAllAsync(cancellationToken);
        return Ok(articles);
    }
}
