﻿/*
Deployment script for D:\TIENNHM\FINALPROJECT\FINALPROJECT\DATABASE.MDF

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "D:\TIENNHM\FINALPROJECT\FINALPROJECT\DATABASE.MDF"
:setvar DefaultFilePrefix "D_\TIENNHM\FINALPROJECT\FINALPROJECT\DATABASE.MDF_"
:setvar DefaultDataPath "C:\Users\NguyenHuynhMinhTien(\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\"
:setvar DefaultLogPath "C:\Users\NguyenHuynhMinhTien(\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\"

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
PRINT N'Rename [dbo].[CongTy].[DiaChi ] to DiaChi';


GO
EXECUTE sp_rename @objname = N'[dbo].[CongTy].[DiaChi ]', @newname = N'DiaChi', @objtype = N'COLUMN';


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[CongTy]...';


GO
ALTER TABLE [dbo].[CongTy]
    ADD DEFAULT getdate() FOR [CreatedTime];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[CongTy]...';


GO
ALTER TABLE [dbo].[CongTy]
    ADD DEFAULT 0 FOR [IsDeleted];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[CongViec]...';


GO
ALTER TABLE [dbo].[CongViec]
    ADD DEFAULT 0 FOR [IsDeleted];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[CongViec]...';


GO
ALTER TABLE [dbo].[CongViec]
    ADD DEFAULT getdate() FOR [CreatedTime];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[Tinh]...';


GO
ALTER TABLE [dbo].[Tinh]
    ADD DEFAULT 0 FOR [IsDeleted];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[Tinh]...';


GO
ALTER TABLE [dbo].[Tinh]
    ADD DEFAULT getdate() FOR [CreatedTime];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[UngTuyen]...';


GO
ALTER TABLE [dbo].[UngTuyen]
    ADD DEFAULT 0 FOR [IsDeleted];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[UngVien]...';


GO
ALTER TABLE [dbo].[UngVien]
    ADD DEFAULT 0 FOR [IsDeleted];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[UngVien]...';


GO
ALTER TABLE [dbo].[UngVien]
    ADD DEFAULT getdate() FOR [CreatedTime];


GO
PRINT N'Update complete.';


GO
