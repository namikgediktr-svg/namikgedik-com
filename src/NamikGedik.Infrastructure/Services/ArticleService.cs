using NamikGedik.Application.Contracts;

namespace NamikGedik.Infrastructure.Services;

public sealed class ArticleService : IArticleService
{
    public Task<IReadOnlyList<ArticleListItemDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IReadOnlyList<ArticleListItemDto> articles = new[]
        {
            new ArticleListItemDto
            {
                Id = 1,
                Slug = "welcome-to-namikgedik",
                Title = "Welcome to NamikGedik.com",
                Language = "en",
                PublishedAt = DateTime.UtcNow
            }
        };

        return Task.FromResult(articles);
    }
}
