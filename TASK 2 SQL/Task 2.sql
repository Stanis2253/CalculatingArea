Select Product.Name AS 'Продукт', Category.Name AS 'Категория' FROM Product
FULL Join CategoryProduct ON CategoryProduct.IdProduct = Product.id
LEFT JOIN Category ON CategoryProduct.IdCategory = Category.Id