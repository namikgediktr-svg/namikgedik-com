using Microsoft.AspNetCore.Mvc;
using NamikGedik.Api.Models;

namespace NamikGedik.Api.Controllers;

[ApiController]
[Route("api/health")]
public sealed class HealthController : ControllerBase
{
    [HttpGet]
    public ActionResult<HealthResponse> Get()
    {
        return Ok(new HealthResponse());
    }
}
