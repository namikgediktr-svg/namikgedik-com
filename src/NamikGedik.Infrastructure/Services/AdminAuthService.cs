using NamikGedik.Api.Models.Auth;
using NamikGedik.Application.Contracts;

namespace NamikGedik.Infrastructure.Services;

public sealed class AdminAuthService : IAdminAuthService
{
    public Task<LoginResult> SignInAsync(AdminSignInRequest request, CancellationToken cancellationToken = default)
    {
        var isValid = request.Email.Equals("admin@namikgedik.com", StringComparison.OrdinalIgnoreCase)
                      && request.Passcode == "change_me";

        if (!isValid)
        {
            return Task.FromResult(new LoginResult
            {
                Success = false,
                Message = "Invalid credentials."
            });
        }

        return Task.FromResult(new LoginResult
        {
            Success = true,
            Message = "Login successful.",
            AccessToken = "temporary-token-placeholder",
            ExpiresAtUtc = DateTime.UtcNow.AddMinutes(60),
            FullName = "System Administrator",
            Role = "SuperAdmin"
        });
    }
}
