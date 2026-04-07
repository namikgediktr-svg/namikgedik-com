using Microsoft.AspNetCore.Mvc;
using NamikGedik.Application.Contracts;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/management/comments")]
public sealed class ManagementCommentsController : ControllerBase
{
    private readonly ICommentModerationService _commentModerationService;

    public ManagementCommentsController(ICommentModerationService commentModerationService)
    {
        _commentModerationService = commentModerationService;
    }

    [HttpGet("pending")]
    public async Task<IActionResult> GetPending(CancellationToken cancellationToken)
    {
        var comments = await _commentModerationService.GetPendingAsync(cancellationToken);
        return Ok(comments);
    }
}
