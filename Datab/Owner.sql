﻿CREATE TABLE [dbo].[Owner]
(
	
	[OwnerId] INT NOT NULL,
	[Surname] NVARCHAR(50) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[PHONE] NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_OwnerID PRIMARY KEY (OwnerId)

)