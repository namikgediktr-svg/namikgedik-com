namespace NamikGedik.Application.Content;

public sealed class ArticleRecord
{
    public int Id { get; init; }
    public string Slug { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string LanguageCode { get; init; } = string.Empty;
    public bool IsPublished { get; init; }
    public DateTime CreatedAtUtc { get; init; }
    public DateTime? PublishedAtUtc { get; init; }
}
