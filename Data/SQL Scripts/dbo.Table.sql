CREATE TABLE [dbo].[Player]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Username] VARCHAR(MAX) NOT NULL, 
    [FirstName] VARCHAR(MAX) NOT NULL, 
    [Country] VARCHAR(MAX) NOT NULL, 
    [Age] INT NOT NULL
)
