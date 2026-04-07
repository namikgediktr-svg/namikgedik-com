# Wiring Notes

## Purpose
The project now includes service and controller files that should be registered from the API startup flow.

## Intended Integration
Add the following namespace to the API startup file:
- NamikGedik.Api.Extensions

Then call the service registration extension before building the app.

## Registered Services
- IAdminAuthService -> AdminAuthService
- IArticleService -> ArticleService
- ICommentModerationService -> CommentModerationService
- SqlConnectionFactory

## Exposed Endpoints Added
- GET /api/management/articles
- GET /api/management/comments/pending
- GET /api/categories

## Next Technical Step
Update the startup file to use the extension and add database-backed implementations.
