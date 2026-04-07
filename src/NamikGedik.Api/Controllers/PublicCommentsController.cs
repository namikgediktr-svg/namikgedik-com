using Microsoft.AspNetCore.Mvc;
using NamikGedik.Application.Contracts;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/comments")]
public sealed class PublicCommentsController : ControllerBase
{
    private readonly IVisitorCommentService _visitorCommentService;

    public PublicCommentsController(IVisitorCommentService visitorCommentService)
    {
        _visitorCommentService = visitorCommentService;
    }

    [HttpPost]
    public async Task<IActionResult> Submit([FromBody] SubmitCommentRequest request, CancellationToken cancellationToken)
    {
        var result = await _visitorCommentService.SubmitAsync(request, cancellationToken);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
}
