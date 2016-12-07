USE [Frameworks];


GO
PRINT N'Creating [sne]...';


GO
CREATE SCHEMA [sne]
    AUTHORIZATION [dbo];


GO
PRINT N'Creating [sne].[Sequences]...';


GO
CREATE TABLE [sne].[Sequences] (
    [SequenceID]     BIGINT           IDENTITY (1, 1) NOT NULL,
    [ApplicationKey] VARCHAR (50)     NULL,
    [MachineName]    VARCHAR (50)     NULL,
    [Sequence]       VARBINARY (1024) NULL,
    [LastModified]   DATETIME         NULL,
    CONSTRAINT [PK_Sequences] PRIMARY KEY CLUSTERED ([SequenceID] ASC)
);


GO
PRINT N'Creating [sne].[Sequences].[Index_ApplicationKey_Sequences]...';


GO
CREATE UNIQUE NONCLUSTERED INDEX [Index_ApplicationKey_Sequences]
    ON [sne].[Sequences]([ApplicationKey] ASC);


GO
PRINT N'Update complete.';


GO
