
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/17/2017 08:44:03
-- Generated from EDMX file: C:\Users\david\Dropbox\MedAC\projetoexemplo\SolutionMedacProjects\WcfServiceLayer\ModelMedac.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [medacteste];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PatientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientSet];
GO
IF OBJECT_ID(N'[dbo].[MeasurementsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeasurementsSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PatientSet'
CREATE TABLE [dbo].[PatientSet] (
    [IdPatient] int IDENTITY(1,1) NOT NULL,
    [Firstname] nvarchar(max)  NOT NULL,
    [Lastname] nvarchar(max)  NOT NULL,
    [Phone] int  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [Birthdate] datetime  NULL,
    [CC_BI] nvarchar(max)  NOT NULL,
    [SNS] int  NOT NULL,
    [Address] nvarchar(max)  NULL,
    [Gender] nvarchar(1)  NOT NULL,
    [Allergies] nvarchar(max)  NULL,
    [Height] float  NULL,
    [OtherContact] int  NULL
);
GO

-- Creating table 'MeasurementsSet'
CREATE TABLE [dbo].[MeasurementsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BloodPressureMin] int  NULL,
    [BloodPressureMax] int  NULL,
    [HeartRate] int  NULL,
    [OxygenSaturation] int  NULL,
    [Date] datetime  NOT NULL,
    [Time] time  NOT NULL,
    [FK_SNS] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPatient] in table 'PatientSet'
ALTER TABLE [dbo].[PatientSet]
ADD CONSTRAINT [PK_PatientSet]
    PRIMARY KEY CLUSTERED ([IdPatient] ASC);
GO

-- Creating primary key on [Id] in table 'MeasurementsSet'
ALTER TABLE [dbo].[MeasurementsSet]
ADD CONSTRAINT [PK_MeasurementsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------