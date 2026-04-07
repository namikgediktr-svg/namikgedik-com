namespace NamikGedik.Application.Contracts;

public interface ICommentModerationService
{
    Task<IReadOnlyList<ModerationCommentDto>> GetPendingAsync(CancellationToken cancellationToken = default);
}

public sealed class ModerationCommentDto
{
    public long Id { get; init; }
    public int ArticleId { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Text { get; init; } = string.Empty;
    public DateTime CreatedAtUtc { get; init; }
}
