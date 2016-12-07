USE [Frameworks];


GO
PRINT N'Creating [ae]...';


GO
CREATE SCHEMA [ae]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [ae].[AuditLogs]...';


GO
CREATE TABLE [ae].[AuditLogs] (
    [AuditId]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [ReferenceId] BIGINT        NULL,
    [Module]      VARCHAR (50)  NULL,
    [Action]      VARCHAR (50)  NULL,
    [Description] VARCHAR (255) NULL,
    [SessionId]   VARCHAR (100) NULL,
    [LogType]     TINYINT       NULL,
    [CreateDate]  DATETIME      NULL,
    [CreateBy]    VARCHAR (100) NULL,
    CONSTRAINT [PK_AuditLogs] PRIMARY KEY CLUSTERED ([AuditId] ASC)
);


GO
PRINT N'Creating [ae].[AuditLogDetails]...';


GO
CREATE TABLE [ae].[AuditLogDetails] (
    [DetailId]   BIGINT          IDENTITY (1, 1) NOT NULL,
    [AuditId]    BIGINT          NULL,
    [Activity]   TINYINT         NULL,
    [OldData]    VARBINARY (MAX) NULL,
    [NewData]    VARBINARY (MAX) NULL,
    [EntityType] VARCHAR (255)   NULL,
    [CreateDate] DATETIME        NULL,
    [CreateBy]   VARCHAR (100)   NULL,
    CONSTRAINT [PK_AuditLogDetails_1] PRIMARY KEY CLUSTERED ([DetailId] ASC)
);


GO
PRINT N'Creating [ae].[TextAuditLogDetails]...';


GO
CREATE TABLE [ae].[TextAuditLogDetails] (
    [DetailId]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [AuditId]    BIGINT        NULL,
    [Activity]   TINYINT       NULL,
    [OldData]    VARCHAR (MAX) NULL,
    [NewData]    VARCHAR (MAX) NULL,
    [EntityType] VARCHAR (255) NULL,
    [CreateDate] DATETIME      NULL,
    [CreateBy]   VARCHAR (100) NULL,
    CONSTRAINT [PK_AuditLogDetails] PRIMARY KEY CLUSTERED ([DetailId] ASC)
);


GO
PRINT N'Creating [ae].[FK_AuditLogDetails_AuditLogs]...';


GO
ALTER TABLE [ae].[AuditLogDetails]
    ADD CONSTRAINT [FK_AuditLogDetails_AuditLogs] FOREIGN KEY ([AuditId]) REFERENCES [ae].[AuditLogs] ([AuditId]) ON DELETE CASCADE;


GO
PRINT N'Creating [ae].[FK_TextAuditLogDetails_AuditLogs]...';


GO
ALTER TABLE [ae].[TextAuditLogDetails]
    ADD CONSTRAINT [FK_TextAuditLogDetails_AuditLogs] FOREIGN KEY ([AuditId]) REFERENCES [ae].[AuditLogs] ([AuditId]) ON DELETE CASCADE;


GO
PRINT N'Update complete.';


GO
