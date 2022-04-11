CREATE TABLe [dbo].[Users] (
	[Id]          INT IDENTITY(1, 1) NOT NULL,
	[FirstName]   VARCHAR (50)   NOT NULL,
    [LastName]    VARCHAR (50)   NOT NULL,
    [Email]       VARCHAR (100)  NOT NULL,
	[Password]    VARCHAR (1000) NOT NULL,
	CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
)