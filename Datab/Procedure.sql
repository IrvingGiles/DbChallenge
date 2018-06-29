CREATE TABLE [dbo].[Procedure]
(
	[ProcedureId] INT NOT NULL,
	[Description] NVARCHAR(100) NOT NULL,
	[Price] MONEY NOT NULL,
	CONSTRAINT PK_ProcedureId PRIMARY KEY (ProcedureId)
)
