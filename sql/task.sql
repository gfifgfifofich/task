SELECT Products.name AS productName, Category.name AS categoryName 
FROM Products
LEFT JOIN ProdCat ON Products.id = ProdCat.products_id
INNER JOIN Category  ON Category.id = ProdCat.category_id;