namespace NamikGedik.Api.Models.Auth;

public sealed class LoginResult
{
    public bool Success { get; init; }
    public string Message { get; init; } = string.Empty;
    public string? AccessToken { get; init; }
    public DateTime? ExpiresAtUtc { get; init; }
    public string? FullName { get; init; }
    public string? Role { get; init; }
}
