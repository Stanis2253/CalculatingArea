Select Product.Name AS '�������', Category.Name AS '���������' FROM Product
FULL Join CategoryProduct ON CategoryProduct.IdProduct = Product.id
LEFT JOIN Category ON CategoryProduct.IdCategory = Category.Id