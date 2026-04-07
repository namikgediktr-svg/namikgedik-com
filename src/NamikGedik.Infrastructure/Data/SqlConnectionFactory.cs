using Microsoft.Data.SqlClient;

namespace NamikGedik.Infrastructure.Data;

public sealed class SqlConnectionFactory
{
    private readonly SqlConnectionSettings _settings;

    public SqlConnectionFactory(SqlConnectionSettings settings)
    {
        _settings = settings;
    }

    public SqlConnection Create()
    {
        return new SqlConnection(_settings.BuildConnectionString());
    }
}
