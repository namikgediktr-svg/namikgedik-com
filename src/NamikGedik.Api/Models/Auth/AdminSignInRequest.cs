namespace NamikGedik.Api.Models.Auth;

public sealed class AdminSignInRequest
{
    public string Email { get; set; } = string.Empty;
    public string Passcode { get; set; } = string.Empty;
}
