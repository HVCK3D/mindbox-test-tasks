--Таблица с продуктами имеет название Products. Ее колонки:
--	Id - Ид продукта
--	Name - Название продукта

--Таблица с категориями имеет название Categories. Ее колонки:
--	Id - Ид категории
--	Name - Название категории

-- Связывающая таблица - ProductsCategories. Ее колонки:
--	ProductId - Ид продукта
--	CategoryId - Ид категории


SELECT p."Name" as "ProductName", c."Name" as "CategoryName" FROM "Products" AS p
LEFT JOIN "ProductsCategories" AS pc ON p."Id" = pc."ProductId"
LEFT JOIN "Categories" AS c ON c."Id" = pc."CategoryId"