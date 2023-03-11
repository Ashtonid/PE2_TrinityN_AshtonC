CREATE TABLE [dbo].[Table]
(
	[memid] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(20) NULL, 
    [fname] VARCHAR(30) NULL, 
    [lname] VARCHAR(30) NULL, 
    [password] VARCHAR(25) NULL, 
    [phonenum] TEXT NULL, 
    [email] VARCHAR(30) NOT NULL, 
    [lastlogin] DATETIME NULL, 
    [shoesize] DECIMAL(3) NOT NULL, 
    [isadmin] BIT NOT NULL, 
    [address] VARCHAR(50) NOT NULL, 
    [usertype] VARCHAR(8) NULL
)
