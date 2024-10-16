--������� � ���������� ����� �������� Products. �� �������:
--	Id - �� ��������
--	Name - �������� ��������

--������� � ����������� ����� �������� Categories. �� �������:
--	Id - �� ���������
--	Name - �������� ���������

-- ����������� ������� - ProductsCategories. �� �������:
--	ProductId - �� ��������
--	CategoryId - �� ���������


SELECT p."Name" as "ProductName", c."Name" as "CategoryName" FROM "Products" AS p
LEFT JOIN "ProductsCategories" AS pc ON p."Id" = pc."ProductId"
LEFT JOIN "Categories" AS c ON c."Id" = pc."CategoryId"