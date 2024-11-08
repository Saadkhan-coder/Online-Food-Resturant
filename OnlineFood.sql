CREATE TABLE [dbo].[Orderfood] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [PhoneNumber] NVARCHAR (15)  NOT NULL,
    [Address]     NVARCHAR (255) NOT NULL,
    [Email]       NVARCHAR (100) NOT NULL,
    [FoodItem]    NVARCHAR (100) NOT NULL,
    [Quantity]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

