CREATE TABLE dbo.Template
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Data] NVARCHAR(MAX)    
)

INSERT INTO dbo.Template ([Data])
VALUES ('Template1'),
       ('Template2')

SELECT *
FROM dbo.Template
