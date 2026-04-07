namespace NamikGedik.Application.Content;

public sealed class CommentRecord
{
    public long Id { get; init; }
    public int ArticleId { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Text { get; init; } = string.Empty;
    public bool IsApproved { get; init; }
    public DateTime CreatedAtUtc { get; init; }
}
