
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2017 13:57:44
-- Generated from EDMX file: C:\Users\david\Desktop\MyHealth\SolutionMedacProjects\WcfServiceLayer\ModelMedac.edmx
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
IF OBJECT_ID(N'[dbo].[MeasurementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeasurementSet];
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

-- Creating table 'MeasurementSet'
CREATE TABLE [dbo].[MeasurementSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BloodPressureMin] int  NOT NULL,
    [BloodPressureMax] int  NOT NULL,
    [HeartRate] int  NOT NULL,
    [OxygenSaturation] int  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Time] nvarchar(max)  NOT NULL,
    [FK_Sns] int  NOT NULL
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

-- Creating primary key on [Id] in table 'MeasurementSet'
ALTER TABLE [dbo].[MeasurementSet]
ADD CONSTRAINT [PK_MeasurementSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------