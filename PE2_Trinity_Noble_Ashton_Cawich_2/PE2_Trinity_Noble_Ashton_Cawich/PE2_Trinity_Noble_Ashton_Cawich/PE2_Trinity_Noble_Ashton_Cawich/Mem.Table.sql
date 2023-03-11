CREATE TABLE [Member].[Table]
(
	[memid] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(25) NULL, 
    [password] VARCHAR(30) NULL, 
    [fname] VARCHAR(30) NULL, 
    [lname] VARCHAR(30) NULL, 
    [email] VARCHAR(30) NOT NULL, 
    [phone] TEXT NOT NULL, 
    [isadmin] BIT NOT NULL, 
    [usertype] VARCHAR(20) NULL, 
    [lastlogin] DATETIME NULL
)
