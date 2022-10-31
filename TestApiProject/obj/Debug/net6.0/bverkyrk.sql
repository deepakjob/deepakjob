IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [ProductDetails] (
    [slNo] int NOT NULL IDENTITY,
    [ProductName] nvarchar(max) NOT NULL,
    [ProductDetail] nvarchar(max) NOT NULL,
    [Price] int NOT NULL,
    [ProductType] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_ProductDetails] PRIMARY KEY ([slNo])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'slNo', N'Price', N'ProductDetail', N'ProductName', N'ProductType') AND [object_id] = OBJECT_ID(N'[ProductDetails]'))
    SET IDENTITY_INSERT [ProductDetails] ON;
INSERT INTO [ProductDetails] ([slNo], [Price], [ProductDetail], [ProductName], [ProductType])
VALUES (101, 2000, N'Operating System', N'Windows OS', N'Hardware');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'slNo', N'Price', N'ProductDetail', N'ProductName', N'ProductType') AND [object_id] = OBJECT_ID(N'[ProductDetails]'))
    SET IDENTITY_INSERT [ProductDetails] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221030110356_SecondMigraton', N'6.0.10');
GO

COMMIT;
GO

