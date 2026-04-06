# Deployment Notes

## Target Environment
- Windows Server
- IIS
- Domain: namikgedik.com

## Initial Deployment Principles
- Separate environments for development and production
- Keep secrets out of source control
- Use environment variables or secure configuration storage
- Log application and deployment errors centrally

## Minimum Checklist
- Domain and DNS preparation
- SSL certificate
- IIS site binding
- Reverse proxy or direct hosting plan
- Database connection configuration
- SMTP configuration for notifications
- Backup plan for database and uploaded files

## Operational Notes
- Use a staging environment before production
- Keep deployment scripts documented
- Track release notes for every production change
