-- The table with products is named Products. Its columns:
--    Id - Product ID
--    Name - Product Name

-- The table with categories is named Categories. Its columns:
--    Id - Category ID
--    Name - Category Name

-- The linking table is ProductsCategories. Its columns:
--    ProductId - Product ID
--    CategoryId - Category ID


SELECT p."Name" as "ProductName", c."Name" as "CategoryName" FROM "Products" AS p
LEFT JOIN "ProductsCategories" AS pc ON p."Id" = pc."ProductId"
LEFT JOIN "Categories" AS c ON c."Id" = pc."CategoryId"