SELECT prod.ProductName, cat.CategoryName FROM Products prod with(nolock)
LEFT JOIN Product_Category prod_Cat with(nolock) ON prod.ProductID = prod_Cat.ProductID
LEFT JOIN Categories cat with(nolock) ON prod_Cat.CategoryID = cat.CategoryID