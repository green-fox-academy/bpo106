CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Task] VARCHAR(50) NOT NULL, 
    [Urgent] BIT NOT NULL, 
    [Done] BIT NOT NULL
)
