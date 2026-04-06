namespace NamikGedik.Application.Contracts;

public interface IArticleService
{
    Task<IReadOnlyList<ArticleListItemDto>> GetAllAsync(CancellationToken cancellationToken = default);
}

public sealed class ArticleListItemDto
{
    public int Id { get; init; }
    public string Slug { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string Language { get; init; } = string.Empty;
    public DateTime PublishedAt { get; init; }
}
