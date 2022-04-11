﻿/*
Deployment script for SentenceGeneratorDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SentenceGeneratorDB"
:setvar DefaultFilePrefix "SentenceGeneratorDB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating Table [dbo].[Sentences]...';


GO
CREATE TABLE [dbo].[Sentences] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Sentence] NVARCHAR (MAX) NOT NULL,
    [UserId]   INT            NOT NULL,
    CONSTRAINT [PK_Sentences] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating Table [dbo].[Users]...';


GO
CREATE TABLE [dbo].[Users] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50)   NOT NULL,
    [LastName]  VARCHAR (50)   NOT NULL,
    [Email]     VARCHAR (100)  NOT NULL,
    [Password]  VARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Sentences_User]...';


GO
ALTER TABLE [dbo].[Sentences] WITH NOCHECK
    ADD CONSTRAINT [FK_Sentences_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Sentences] WITH CHECK CHECK CONSTRAINT [FK_Sentences_User];


GO
PRINT N'Update complete.';


GO
