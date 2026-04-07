using NamikGedik.Application.Contracts;

namespace NamikGedik.Infrastructure.Services;

public sealed class CommentModerationService : ICommentModerationService
{
    public Task<IReadOnlyList<ModerationCommentDto>> GetPendingAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyList<ModerationCommentDto> comments = new[]
        {
            new ModerationCommentDto
            {
                Id = 1,
                ArticleId = 1,
                FullName = "Visitor User",
                Email = "visitor@example.com",
                Text = "Great article.",
                CreatedAtUtc = DateTime.UtcNow
            }
        };

        return Task.FromResult(comments);
    }
}
