-- The following are the statement for creating queue and service. Please change them appropriately before use.

USE [Frameworks];

GO
PRINT N'Creating [dbo].[QueueName]...';

-- Create a queue. Please change to an appropriate queue name.
GO
-- CREATE QUEUE [dbo].[QueueName];


GO
PRINT N'Creating [ServiceName]...';


-- Create a service. Please change to an appropriate service name.
GO
--CREATE SERVICE [ServiceName]
--    ON QUEUE [dbo].[QueueName]
--    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

GO

-- Enable service broker. Be wary that running this statement may cause to wait indefinitely.
-- ALTER DATABASE [Frameworks] SET ENABLE_BROKER

GO

