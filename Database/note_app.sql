BEGIN TRAN

USE Notes;

IF OBJECT_ID('Note') IS NOT NULL BEGIN DROP TABLE Note END;

CREATE TABLE Note
(
	id BIGINT PRIMARY KEY IDENTITY(1,1) not null,
	title VARCHAR(200) NULL,
	description TEXT NULL,
	created_by BIGINT NULL,
	created_at DATETIME NULL,
	updated_by BIGINT NULL,
	updated_at DATETIME NULL,
	deleted_by BIGINT NULL,
	deleted_at BIGINT NULL,
);


COMMIT TRAN