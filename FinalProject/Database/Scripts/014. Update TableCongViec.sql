﻿/*
Deployment script for D:\22110006_VI QUOC THUAN\LAP_TRINH_WINDOWS\DOANCUOIKY\PROJECT\FINALPROJECT\FINALPROJECT\DATABASE.MDF

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "D:\22110006_VI QUOC THUAN\LAP_TRINH_WINDOWS\DOANCUOIKY\PROJECT\FINALPROJECT\FINALPROJECT\DATABASE.MDF"
:setvar DefaultFilePrefix "D_\22110006_VI QUOC THUAN\LAP_TRINH_WINDOWS\DOANCUOIKY\PROJECT\FINALPROJECT\FINALPROJECT\DATABASE.MDF_"
:setvar DefaultDataPath "C:\Users\van pho\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\van pho\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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

IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
BEGIN TRANSACTION
GO
/*
The column [dbo].[CongViec].[Id] is being dropped, data loss could occur.

The column [dbo].[CongViec].[IdCongTy] on table [dbo].[CongViec] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/
GO
PRINT N'Starting rebuilding table [dbo].[CongViec]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_CongViec] (
    [IdCongTy]       INT             NOT NULL,
    [TenCongTy]      NVARCHAR (500)  NULL,
    [Ten]            NVARCHAR (500)  NULL,
    [Nganh]          NVARCHAR (100)  NULL,
    [ViTriTuyenDung] NVARCHAR (100)  NULL,
    [MucLuong]       DECIMAL (18)    NULL,
    [DiaDiem]        NVARCHAR (255)  NULL,
    [TrinhDoHocVan]  NVARCHAR (255)  NULL,
    [GioiTinh]       NVARCHAR (20)   NULL,
    [LienHe]         NVARCHAR (100)  NULL,
    [MoTa]           NVARCHAR (2000) NULL,
    [QuyenLoi]       NVARCHAR (2000) NULL,
    [NgoaiNgu]       NVARCHAR (2000) NULL,
    [TinHoc]         NVARCHAR (2000) NULL,
    [KinhNghiem]     NVARCHAR (2000) NULL,
    [KyNang]         NVARCHAR (2000) NULL,
    [FromDate]       DATE            NULL,
    [ToDate]         DATE            NULL,
    [TrangThai]      NVARCHAR (50)   NULL,
    [SoLuong]        INT             NULL,
    [Link]           NVARCHAR (500)  NULL,
    [IsDeleted]      BIT             NULL,
    [CreatedTime]    DATE            NULL,
    [UpdatedTime]    DATE            NULL,
    PRIMARY KEY CLUSTERED ([IdCongTy] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[CongViec])
    BEGIN
        INSERT INTO [dbo].[tmp_ms_xx_CongViec] ([Ten], [Nganh], [ViTriTuyenDung], [MucLuong], [DiaDiem], [TrinhDoHocVan], [GioiTinh], [LienHe], [MoTa], [QuyenLoi], [NgoaiNgu], [TinHoc], [KinhNghiem], [KyNang], [FromDate], [ToDate], [TrangThai], [SoLuong], [Link], [IsDeleted], [CreatedTime], [UpdatedTime])
        SELECT [Ten],
               [Nganh],
               [ViTriTuyenDung],
               [MucLuong],
               [DiaDiem],
               [TrinhDoHocVan],
               [GioiTinh],
               [LienHe],
               [MoTa],
               [QuyenLoi],
               [NgoaiNgu],
               [TinHoc],
               [KinhNghiem],
               [KyNang],
               [FromDate],
               [ToDate],
               [TrangThai],
               [SoLuong],
               [Link],
               [IsDeleted],
               [CreatedTime],
               [UpdatedTime]
        FROM   [dbo].[CongViec];
    END

DROP TABLE [dbo].[CongViec];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_CongViec]', N'CongViec';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF OBJECT_ID(N'tempdb..#tmpErrors') IS NULL
    CREATE TABLE [#tmpErrors] (
        Error INT
    );

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT N'The transacted portion of the database update succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT N'The transacted portion of the database update failed.'
GO
IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
GO
PRINT N'Update complete.';


GO
