# Architecture Draft

## Recommended Structure

### Public Layer
- Public website for article, category, and media pages
- SEO-friendly routes
- Multi-language page structure

### Admin Layer
- Secure admin login
- Article, category, media, and comment management
- Role-ready structure for future growth

### API Layer
- Authentication endpoints
- Content endpoints
- Comment endpoints
- Media upload endpoints
- Health check endpoints

### Database Layer
Recommended initial entities:
- users
- roles
- articles
- article_translations
- categories
- category_translations
- comments
- media_files
- audit_logs

## Suggested Tech Direction
Option A:
- Next.js frontend
- Node.js / NestJS API
- PostgreSQL or SQL Server

Option B:
- ASP.NET Core MVC / Web API
- SQL Server
- IIS deployment

## Recommended for Current Goal
Because IIS deployment is important, ASP.NET Core + SQL Server is a strong primary option.

## Security Baseline
- Environment-based configuration
- Password hashing
- Role-based authorization
- Input validation
- File upload restrictions
- Admin audit logging
- Basic rate limiting for comments and login
