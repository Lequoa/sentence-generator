CREATE TABLE [dbo].[Sentences] (
 [Id] INT IDENTITY(1, 1) NOT NULL,
 [SentenceText] NVARCHAR(MAX) NOT NULL,
 [UserId] INT NOT NULL,
 CONSTRAINT [PK_Sentences] PRIMARY KEY CLUSTERED ([Id] ASC),
 CONSTRAINT [FK_Sentences_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] (Id)
);