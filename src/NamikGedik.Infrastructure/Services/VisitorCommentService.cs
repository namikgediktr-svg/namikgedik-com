using NamikGedik.Application.Contracts;

namespace NamikGedik.Infrastructure.Services;

public sealed class VisitorCommentService : IVisitorCommentService
{
    public Task<SubmitCommentResult> SubmitAsync(SubmitCommentRequest request, CancellationToken cancellationToken = default)
    {
        if (request.ArticleId <= 0 || string.IsNullOrWhiteSpace(request.FullName) || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Text))
        {
            return Task.FromResult(new SubmitCommentResult
            {
                Success = false,
                Message = "Invalid comment payload."
            });
        }

        return Task.FromResult(new SubmitCommentResult
        {
            Success = true,
            Message = "Comment submitted for moderation."
        });
    }
}
