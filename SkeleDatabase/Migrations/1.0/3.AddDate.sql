ALTER TABLE [TestData] ADD
	[CreatedAt] DATETIME NULL
GO

UPDATE [TestData] SET [CreatedAt] = SYSDATETIME()

ALTER TABLE [TestData] ALTER COLUMN 
	[CreatedAt] DATETIME NOT NULL
GO

