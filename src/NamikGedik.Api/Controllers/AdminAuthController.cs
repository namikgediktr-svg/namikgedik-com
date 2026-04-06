using Microsoft.AspNetCore.Mvc;
using NamikGedik.Api.Models.Auth;
using NamikGedik.Application.Contracts;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/admin/auth")]
public sealed class AdminAuthController : ControllerBase
{
    private readonly IAdminAuthService _adminAuthService;

    public AdminAuthController(IAdminAuthService adminAuthService)
    {
        _adminAuthService = adminAuthService;
    }

    [HttpPost("sign-in")]
    public async Task<ActionResult<LoginResult>> SignIn([FromBody] AdminSignInRequest request, CancellationToken cancellationToken)
    {
        var result = await _adminAuthService.SignInAsync(request, cancellationToken);

        if (!result.Success)
        {
            return Unauthorized(result);
        }

        return Ok(result);
    }
}
