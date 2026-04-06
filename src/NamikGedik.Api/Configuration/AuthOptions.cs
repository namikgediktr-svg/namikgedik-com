namespace NamikGedik.Api.Configuration;

public sealed class AuthOptions
{
    public const string SectionName = "Auth";

    public string Issuer { get; set; } = "namikgedik.com";
    public string Audience { get; set; } = "namikgedik-admin";
    public string SecretKey { get; set; } = "change_me_please_32_chars_minimum";
    public int AccessTokenMinutes { get; set; } = 60;
}
