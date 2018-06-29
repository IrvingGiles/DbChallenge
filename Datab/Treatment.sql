CREATE TABLE [dbo].[Treatment]
(
	[TreatmentId] INT NOT NULL,
	[ProcedureId] INT NOT NULL,
	[PetId] INT NOT NULL,
	[PetName] NVARCHAR(50) NOT NUll,
	[ownerId] INT NOT NULL,
	[Dates] DATE NOT NULL,
	[Notes] NVARCHAR(100) NOT NULL,
	[Price] MONEY NOT NULL,
	CONSTRAINT PK_TreatmentId PRIMARY KEY (TreatmentId),
	CONSTRAINT FK_ProcedureId FOREIGN KEY (ProcedureId) REFERENCES [dbo].[Procedure](ProcedureId),
	CONSTRAINT FK_PetId FOREIGN KEY (PetId) REFERENCES [dbo].[Pet](PetId),
)
