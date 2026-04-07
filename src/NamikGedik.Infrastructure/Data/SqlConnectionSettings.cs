namespace NamikGedik.Infrastructure.Data;

public sealed class SqlConnectionSettings
{
    public string Host { get; init; } = string.Empty;
    public int Port { get; init; } = 1433;
    public string Database { get; init; } = string.Empty;
    public string UserName { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;

    public string BuildConnectionString()
    {
        return $"Server={Host},{Port};Database={Database};User Id={UserName};Password={Password};TrustServerCertificate=True;Encrypt=True;";
    }
}
