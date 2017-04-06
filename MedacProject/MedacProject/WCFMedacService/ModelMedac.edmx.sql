
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/06/2017 08:19:59
-- Generated from EDMX file: C:\Users\david\Desktop\MyHealth\MedacProject\MedacProject\WCFMedacService\ModelMedac.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MedacDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PatientMeasurement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeasurementSet] DROP CONSTRAINT [FK_PatientMeasurement];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorPatient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientSet] DROP CONSTRAINT [FK_DoctorPatient];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PatientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientSet];
GO
IF OBJECT_ID(N'[dbo].[MeasurementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeasurementSet];
GO
IF OBJECT_ID(N'[dbo].[DoctorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PatientSet'
CREATE TABLE [dbo].[PatientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Phone] int  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [BirthDate] datetime  NOT NULL,
    [CC_BI] int  NOT NULL,
    [SNS] int  NOT NULL,
    [Address] nvarchar(max)  NULL,
    [Gender] nvarchar(1)  NOT NULL,
    [Allergies] nvarchar(max)  NULL,
    [Height] float  NULL,
    [OtherContact] nvarchar(max)  NULL,
    [Logged] bit  NOT NULL,
    [Doctor_Id] int  NOT NULL
);
GO

-- Creating table 'MeasurementSet'
CREATE TABLE [dbo].[MeasurementSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BloodPressureMin] int  NULL,
    [BloodPressureMax] int  NULL,
    [HeartRate] int  NULL,
    [OxygenSaturation] int  NULL,
    [Date] datetime  NOT NULL,
    [Time] time  NOT NULL,
    [Patient_Id] int  NOT NULL
);
GO

-- Creating table 'DoctorSet'
CREATE TABLE [dbo].[DoctorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ProfessionalNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AlertSet'
CREATE TABLE [dbo].[AlertSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Warning] nvarchar(max)  NOT NULL,
    [Critical] nvarchar(max)  NOT NULL,
    [Patient_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PatientSet'
ALTER TABLE [dbo].[PatientSet]
ADD CONSTRAINT [PK_PatientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MeasurementSet'
ALTER TABLE [dbo].[MeasurementSet]
ADD CONSTRAINT [PK_MeasurementSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DoctorSet'
ALTER TABLE [dbo].[DoctorSet]
ADD CONSTRAINT [PK_DoctorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AlertSet'
ALTER TABLE [dbo].[AlertSet]
ADD CONSTRAINT [PK_AlertSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Patient_Id] in table 'MeasurementSet'
ALTER TABLE [dbo].[MeasurementSet]
ADD CONSTRAINT [FK_PatientMeasurement]
    FOREIGN KEY ([Patient_Id])
    REFERENCES [dbo].[PatientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientMeasurement'
CREATE INDEX [IX_FK_PatientMeasurement]
ON [dbo].[MeasurementSet]
    ([Patient_Id]);
GO

-- Creating foreign key on [Doctor_Id] in table 'PatientSet'
ALTER TABLE [dbo].[PatientSet]
ADD CONSTRAINT [FK_DoctorPatient]
    FOREIGN KEY ([Doctor_Id])
    REFERENCES [dbo].[DoctorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorPatient'
CREATE INDEX [IX_FK_DoctorPatient]
ON [dbo].[PatientSet]
    ([Doctor_Id]);
GO

-- Creating foreign key on [Patient_Id] in table 'AlertSet'
ALTER TABLE [dbo].[AlertSet]
ADD CONSTRAINT [FK_PatientAlert]
    FOREIGN KEY ([Patient_Id])
    REFERENCES [dbo].[PatientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientAlert'
CREATE INDEX [IX_FK_PatientAlert]
ON [dbo].[AlertSet]
    ([Patient_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------