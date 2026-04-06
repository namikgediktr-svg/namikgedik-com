namespace NamikGedik.Api.Models;

public sealed class HealthResponse
{
    public string Status { get; init; } = "ok";
    public string Service { get; init; } = "namikgedik-api";
    public DateTime UtcTime { get; init; } = DateTime.UtcNow;
}
