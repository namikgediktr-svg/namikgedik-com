using NamikGedik.Api.Models.Auth;

namespace NamikGedik.Application.Contracts;

public interface IAdminAuthService
{
    Task<LoginResult> SignInAsync(AdminSignInRequest request, CancellationToken cancellationToken = default);
}
