CREATE TABLE [dbo].[List] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [Comments]           NVARCHAR (MAX) NULL,
    [DateOfGet]          NVARCHAR (MAX) NOT NULL,
    [DateOfWithdrawal]   NVARCHAR (MAX) NULL,
    [Depot]              NVARCHAR (MAX) NOT NULL,
    [FormerLicensePlate] NVARCHAR (MAX) NULL,
    [FormerNumber]       INT            NULL,
    [IsInOperation]      BIT            NOT NULL,
    [Kilometer]          INT            NOT NULL,
    [LicensePlate]       NVARCHAR (MAX) NOT NULL,
    [Number]             INT            NULL,
    [Type]               NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_List] PRIMARY KEY CLUSTERED ([Id] ASC)
);

