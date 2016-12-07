USE [Frameworks];

GO
PRINT N'Creating [ace]...';


GO
CREATE SCHEMA [ace]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [ace].[Tokens]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[Tokens] (
    [TokenID]      BIGINT       IDENTITY (1, 1) NOT NULL,
    [UserID]       BIGINT       NULL,
    [TokenValue]   VARCHAR (20) NOT NULL,
    [DateCreated]  DATETIME     NULL,
    [DateModified] DATETIME     NULL,
    CONSTRAINT [PK_Tokens] PRIMARY KEY CLUSTERED ([TokenID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[SecurityAnswers]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[SecurityAnswers] (
    [UserID]       BIGINT         NOT NULL,
    [QuestionID]   INT            NOT NULL,
    [Answer]       NVARCHAR (100) NULL,
    [DateCreated]  DATETIME       NULL,
    [DateModified] DATETIME       NULL,
    CONSTRAINT [PK_SecurityAnswers] PRIMARY KEY CLUSTERED ([UserID] ASC, [QuestionID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[RolesPolicies]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[RolesPolicies] (
    [ReferenceID]  INT              NOT NULL,
    [RoleID]       INT              NOT NULL,
    [PolicyID]     UNIQUEIDENTIFIER NOT NULL,
    [Granted]      INT              NULL,
    [Denied]       INT              NULL,
    [DateCreated]  DATETIME         NULL,
    [DateModified] DATETIME         NULL,
    CONSTRAINT [PK_RolesPolicies_1] PRIMARY KEY CLUSTERED ([ReferenceID] ASC, [RoleID] ASC, [PolicyID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[PasswordHistories]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[PasswordHistories] (
    [HistoryID]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [UserID]      BIGINT       NOT NULL,
    [Password]    VARCHAR (200) NOT NULL,
    [DateCreated] DATETIME     NOT NULL,
    CONSTRAINT [PK_PasswordHistories] PRIMARY KEY CLUSTERED ([HistoryID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[LoginHistories]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[LoginHistories] (
    [HistoryID]  BIGINT   IDENTITY (1, 1) NOT NULL,
    [UserID]     BIGINT   NULL,
    [LogType]    TINYINT  NULL,
    [LoggedDate] DATETIME NULL,
    CONSTRAINT [PK_LoginHistories] PRIMARY KEY CLUSTERED ([HistoryID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[SecurityQuestions]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[SecurityQuestions] (
    [QuestionID]    INT            IDENTITY (1, 1) NOT NULL,
    [ApplicationID] INT            NOT NULL,
    [Question]      NVARCHAR (255) NULL,
    [DateCreated]   DATETIME       NULL,
    [DateModified]  DATETIME       NULL,
    CONSTRAINT [PK_SecurityQuestions] PRIMARY KEY CLUSTERED ([QuestionID] ASC),
    CONSTRAINT [UniqueQuestion] UNIQUE NONCLUSTERED ([Question] ASC) ON [PRIMARY]
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[Applications]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[Applications] (
    [ApplicationID] INT           IDENTITY (1, 1) NOT NULL,
    [Domain]        VARCHAR (50)  NULL,
    [Name]          VARCHAR (255) NULL,
    [DateCreated]   DATETIME      NULL,
    [DateModified]  DATETIME      NULL,
    CONSTRAINT [PK_Applications] PRIMARY KEY CLUSTERED ([ApplicationID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[Modules]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[Modules] (
    [ModuleID]      INT           IDENTITY (1, 1) NOT NULL,
    [ParentID]      INT           NULL,
    [ApplicationID] INT           NOT NULL,
    [Name]          VARCHAR (100) NOT NULL,
    [URL]           VARCHAR (255) NULL,
    [Sequence]      INT           NULL,
    [IsHidden]      BIT           NULL,
    [IsPublic]      BIT           NULL,
    [DateCreated]   DATETIME      NULL,
    [DateModified]  DATETIME      NULL,
    CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED ([ModuleID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[ModulesPolicies]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[ModulesPolicies] (
    [ModuleID]    INT              NOT NULL,
    [PolicyID]    UNIQUEIDENTIFIER NOT NULL,
    [Rights]      INT              NULL,
    [DateCreated] DATETIME         NULL,
    [DateModified] DATETIME        NULL,
    CONSTRAINT [PK_ModulesPolicies] PRIMARY KEY CLUSTERED ([ModuleID] ASC, [PolicyID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[Roles]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[Roles] (
    [RoleID]        INT           IDENTITY (1, 1) NOT NULL,
    [ParentID]      INT           NULL,
    [ApplicationID] INT           NOT NULL,
    [Name]          VARCHAR (100) NOT NULL,
    [Description]   VARCHAR (255) NULL,
    [DateCreated]   DATETIME      NULL,
    [DateModified]  DATETIME      NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([RoleID] ASC),
    CONSTRAINT [UniqueRoleName] UNIQUE NONCLUSTERED ([ApplicationID] ASC, [Name] ASC) ON [PRIMARY]
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[Policies]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[Policies] (
    [PolicyID]      UNIQUEIDENTIFIER NOT NULL,
    [ApplicationID] INT              NOT NULL,
    [Name]          VARCHAR (200)    NOT NULL,
    [Description]   VARCHAR (255)    NULL,
    [DateCreated]   DATETIME         NULL,
    [DateModified]  DATETIME         NULL,
    CONSTRAINT [PK_Policies] PRIMARY KEY CLUSTERED ([PolicyID] ASC),
    CONSTRAINT [UniquePolicyName] UNIQUE NONCLUSTERED ([ApplicationID] ASC, [Name] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[Users]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[Users] (
    [UserID]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [UserName]        VARCHAR (20)  NOT NULL,
    [Password]        VARCHAR (200)  NOT NULL,
    [Domain]          VARCHAR (50)  NULL,
    [Email]           VARCHAR (255) NOT NULL,
    [LastLogin]       DATETIME      NULL,
    [LastFailedLogin] DATETIME      NULL,
    [FailedAttempts]  INT           NULL,
    [Status]          TINYINT       NULL,
    [ChangePassword]  BIT           NULL,
    [IsDeleted]       BIT           NULL,
    [DateCreated]     DATETIME      NULL,
    [DateModified]    DATETIME      NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[UsersPolicies]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[UsersPolicies] (
    [ReferenceID]  INT              NOT NULL,
    [UserID]       BIGINT           NOT NULL,
    [PolicyID]     UNIQUEIDENTIFIER NOT NULL,
    [Granted]      INT              NULL,
    [Denied]       INT              NULL,
    [DateCreated]  DATETIME         NULL,
    [DateModified] DATETIME         NULL,
    CONSTRAINT [PK_UsersPolicies_1] PRIMARY KEY CLUSTERED ([ReferenceID] ASC, [UserID] ASC, [PolicyID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[UsersRoles]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE TABLE [ace].[UsersRoles] (
    [UserID]      BIGINT   NOT NULL,
    [RoleID]      INT      NOT NULL,
    [DateCreated] DATETIME NULL,
    CONSTRAINT [PK_UsersRoles] PRIMARY KEY CLUSTERED ([UserID] ASC, [RoleID] ASC)
);


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Creating [ace].[DF_RolesPolicies_ReferenceID]...';


GO
ALTER TABLE [ace].[RolesPolicies]
    ADD CONSTRAINT [DF_RolesPolicies_ReferenceID] DEFAULT ((0)) FOR [ReferenceID];


GO
PRINT N'Creating [ace].[DF_Policies_PolicyKey]...';


GO
ALTER TABLE [ace].[Policies]
    ADD CONSTRAINT [DF_Policies_PolicyKey] DEFAULT newid() FOR [PolicyID];


GO
PRINT N'Creating [ace].[DF_UsersPolicies_ReferenceID]...';


GO
ALTER TABLE [ace].[UsersPolicies]
    ADD CONSTRAINT [DF_UsersPolicies_ReferenceID] DEFAULT ((0)) FOR [ReferenceID];


GO
PRINT N'Creating [ace].[FK_Tokens_Users]...';


GO
ALTER TABLE [ace].[Tokens]
    ADD CONSTRAINT [FK_Tokens_Users] FOREIGN KEY ([UserID]) REFERENCES [ace].[Users] ([UserID]);


GO
PRINT N'Creating [ace].[FK_SecurityAnswers_Users]...';


GO
ALTER TABLE [ace].[SecurityAnswers]
    ADD CONSTRAINT [FK_SecurityAnswers_Users] FOREIGN KEY ([UserID]) REFERENCES [ace].[Users] ([UserID]) ON DELETE CASCADE;


GO
PRINT N'Creating [ace].[FK_SecurityAnswers_SecurityQuestions]...';


GO
ALTER TABLE [ace].[SecurityAnswers]
    ADD CONSTRAINT [FK_SecurityAnswers_SecurityQuestions] FOREIGN KEY ([QuestionID]) REFERENCES [ace].[SecurityQuestions] ([QuestionID]);


GO
PRINT N'Creating [ace].[FK_RolesPolicies_Roles]...';


GO
ALTER TABLE [ace].[RolesPolicies]
    ADD CONSTRAINT [FK_RolesPolicies_Roles] FOREIGN KEY ([RoleID]) REFERENCES [ace].[Roles] ([RoleID]);


GO
PRINT N'Creating [ace].[FK_RolesPolicies_Policies]...';


GO
ALTER TABLE [ace].[RolesPolicies]
    ADD CONSTRAINT [FK_RolesPolicies_Policies] FOREIGN KEY ([PolicyID]) REFERENCES [ace].[Policies] ([PolicyID]);


GO
PRINT N'Creating [ace].[FK_PasswordHistories_Users]...';


GO
ALTER TABLE [ace].[PasswordHistories]
    ADD CONSTRAINT [FK_PasswordHistories_Users] FOREIGN KEY ([UserID]) REFERENCES [ace].[Users] ([UserID]) ON DELETE CASCADE;


GO
PRINT N'Creating [ace].[FK_LoginHistories_Users]...';


GO
ALTER TABLE [ace].[LoginHistories]
    ADD CONSTRAINT [FK_LoginHistories_Users] FOREIGN KEY ([UserID]) REFERENCES [ace].[Users] ([UserID]) ON DELETE CASCADE;


GO
PRINT N'Creating [ace].[FK_Modules_Modules]...';


GO
ALTER TABLE [ace].[Modules]
    ADD CONSTRAINT [FK_Modules_Modules] FOREIGN KEY ([ParentID]) REFERENCES [ace].[Modules] ([ModuleID]);


GO
PRINT N'Creating [ace].[FK_ModulesPolicies_Modules]...';


GO
ALTER TABLE [ace].[ModulesPolicies]
    ADD CONSTRAINT [FK_ModulesPolicies_Modules] FOREIGN KEY ([ModuleID]) REFERENCES [ace].[Modules] ([ModuleID]);


GO
PRINT N'Creating [ace].[FK_ModulesPolicies_Policies]...';


GO
ALTER TABLE [ace].[ModulesPolicies]
    ADD CONSTRAINT [FK_ModulesPolicies_Policies] FOREIGN KEY ([PolicyID]) REFERENCES [ace].[Policies] ([PolicyID]);


GO
PRINT N'Creating [ace].[FK_UsersPolicies_Users]...';


GO
ALTER TABLE [ace].[UsersPolicies]
    ADD CONSTRAINT [FK_UsersPolicies_Users] FOREIGN KEY ([UserID]) REFERENCES [ace].[Users] ([UserID]);


GO
PRINT N'Creating [ace].[FK_UsersPolicies_Policies]...';


GO
ALTER TABLE [ace].[UsersPolicies]
    ADD CONSTRAINT [FK_UsersPolicies_Policies] FOREIGN KEY ([PolicyID]) REFERENCES [ace].[Policies] ([PolicyID]);


GO
PRINT N'Creating [ace].[FK_UsersRoles_Users]...';


GO
ALTER TABLE [ace].[UsersRoles]
    ADD CONSTRAINT [FK_UsersRoles_Users] FOREIGN KEY ([UserID]) REFERENCES [ace].[Users] ([UserID]);


GO
PRINT N'Creating [ace].[FK_Modules_Applications]...';


GO
ALTER TABLE [ace].[Modules] WITH NOCHECK
    ADD CONSTRAINT [FK_Modules_Applications] FOREIGN KEY ([ApplicationID]) REFERENCES [ace].[Applications] ([ApplicationID]);


GO
PRINT N'Creating [ace].[FK_Policies_Applications]...';


GO
ALTER TABLE [ace].[Policies]
    ADD CONSTRAINT [FK_Policies_Applications] FOREIGN KEY ([ApplicationID]) REFERENCES [ace].[Applications] ([ApplicationID]);


GO
PRINT N'Creating [ace].[FK_Roles_Applications]...';


GO
ALTER TABLE [ace].[Roles]
    ADD CONSTRAINT [FK_Roles_Applications] FOREIGN KEY ([ApplicationID]) REFERENCES [ace].[Applications] ([ApplicationID]);


GO
PRINT N'Creating [ace].[FK_SecurityQuestions_Applications]...';


GO
ALTER TABLE [ace].[SecurityQuestions]
    ADD CONSTRAINT [FK_SecurityQuestions_Applications] FOREIGN KEY ([ApplicationID]) REFERENCES [ace].[Applications] ([ApplicationID]);


GO
PRINT N'Creating [ace].[FK_UsersRoles_Roles]...';


GO
ALTER TABLE [ace].[UsersRoles]
    ADD CONSTRAINT [FK_UsersRoles_Roles] FOREIGN KEY ([RoleID]) REFERENCES [ace].[Roles] ([RoleID]);


GO
PRINT N'Creating [dbo].[UsersMessages]...';


GO
CREATE QUEUE [dbo].[UsersMessages];


GO
PRINT N'Creating [UsersNotification]...';


GO
CREATE SERVICE [UsersNotification]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[UsersMessages]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

GO
PRINT N'Update complete.';


GO
