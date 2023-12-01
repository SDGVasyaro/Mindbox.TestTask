SELECT [Product].[name], [Category].[name]
FROM Product
    LEFT JOIN [ProductCategory]
ON [Product].[id] = [ProductCategory].[productId]
    LEFT JOIN [Category]
    ON [Category].[id] = [ProductCategory].[categoryId]