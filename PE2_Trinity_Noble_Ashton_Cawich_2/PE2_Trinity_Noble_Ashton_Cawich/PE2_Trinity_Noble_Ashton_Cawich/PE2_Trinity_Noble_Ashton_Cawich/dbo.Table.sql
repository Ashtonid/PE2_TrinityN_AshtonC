CREATE TABLE [dbo].[Table]
(
	[MemId] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(20) NULL, 
    [fname] VARCHAR(30) NULL, 
    [lname] VARCHAR(30) NULL, 
    [password] VARCHAR(25) NULL, 
    [phone] TEXT NOT NULL, 
    [isadmin] BIT NOT NULL, 
    [usertype] VARCHAR(10) NULL, 
    [lastlogin] DATETIME2 NULL, 
    [email] VARCHAR(30) NOT NULL
)
