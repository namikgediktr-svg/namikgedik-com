CREATE TABLE roles (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL UNIQUE,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    full_name NVARCHAR(200) NOT NULL,
    email NVARCHAR(200) NOT NULL UNIQUE,
    password_hash NVARCHAR(500) NOT NULL,
    role_id INT NOT NULL,
    is_active BIT NOT NULL DEFAULT 1,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NULL,
    CONSTRAINT FK_users_roles FOREIGN KEY (role_id) REFERENCES roles(id)
);

CREATE TABLE categories (
    id INT IDENTITY(1,1) PRIMARY KEY,
    slug NVARCHAR(200) NOT NULL UNIQUE,
    is_active BIT NOT NULL DEFAULT 1,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE TABLE category_translations (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category_id INT NOT NULL,
    language_code NVARCHAR(10) NOT NULL,
    title NVARCHAR(200) NOT NULL,
    description NVARCHAR(1000) NULL,
    CONSTRAINT FK_category_translations_categories FOREIGN KEY (category_id) REFERENCES categories(id),
    CONSTRAINT UQ_category_translation UNIQUE (category_id, language_code)
);

CREATE TABLE articles (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category_id INT NULL,
    slug NVARCHAR(250) NOT NULL UNIQUE,
    cover_image_url NVARCHAR(500) NULL,
    is_published BIT NOT NULL DEFAULT 0,
    published_at DATETIME2 NULL,
    created_by_user_id INT NOT NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    updated_at DATETIME2 NULL,
    CONSTRAINT FK_articles_categories FOREIGN KEY (category_id) REFERENCES categories(id),
    CONSTRAINT FK_articles_users FOREIGN KEY (created_by_user_id) REFERENCES users(id)
);

CREATE TABLE article_translations (
    id INT IDENTITY(1,1) PRIMARY KEY,
    article_id INT NOT NULL,
    language_code NVARCHAR(10) NOT NULL,
    title NVARCHAR(250) NOT NULL,
    summary NVARCHAR(1000) NULL,
    content NVARCHAR(MAX) NOT NULL,
    seo_title NVARCHAR(250) NULL,
    seo_description NVARCHAR(500) NULL,
    CONSTRAINT FK_article_translations_articles FOREIGN KEY (article_id) REFERENCES articles(id),
    CONSTRAINT UQ_article_translation UNIQUE (article_id, language_code)
);

CREATE TABLE comments (
    id INT IDENTITY(1,1) PRIMARY KEY,
    article_id INT NOT NULL,
    full_name NVARCHAR(200) NOT NULL,
    email NVARCHAR(200) NOT NULL,
    comment_text NVARCHAR(2000) NOT NULL,
    is_approved BIT NOT NULL DEFAULT 0,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_comments_articles FOREIGN KEY (article_id) REFERENCES articles(id)
);

CREATE TABLE media_files (
    id INT IDENTITY(1,1) PRIMARY KEY,
    original_file_name NVARCHAR(255) NOT NULL,
    stored_file_name NVARCHAR(255) NOT NULL,
    file_path NVARCHAR(500) NOT NULL,
    mime_type NVARCHAR(100) NOT NULL,
    file_size_bytes BIGINT NOT NULL,
    uploaded_by_user_id INT NOT NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_media_files_users FOREIGN KEY (uploaded_by_user_id) REFERENCES users(id)
);

CREATE TABLE audit_logs (
    id BIGINT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NULL,
    action_name NVARCHAR(200) NOT NULL,
    entity_name NVARCHAR(100) NOT NULL,
    entity_id NVARCHAR(100) NULL,
    details NVARCHAR(MAX) NULL,
    created_at DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_audit_logs_users FOREIGN KEY (user_id) REFERENCES users(id)
);
