namespace NamikGedik.Application.Contracts;

public interface IVisitorCommentService
{
    Task<SubmitCommentResult> SubmitAsync(SubmitCommentRequest request, CancellationToken cancellationToken = default);
}

public sealed class SubmitCommentRequest
{
    public int ArticleId { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Text { get; init; } = string.Empty;
}

public sealed class SubmitCommentResult
{
    public bool Success { get; init; }
    public string Message { get; init; } = string.Empty;
}
