CREATE TABLE [dbo].[TestOrderProducts] (
    [id]        INT   IDENTITY (1, 1) NOT NULL,
    [OrderId]   INT   NULL,
    [ProductId] INT   NULL,
    [Quantity]  INT   NULL,
    [Price]     MONEY NULL,
    [Total]     MONEY NULL
);

