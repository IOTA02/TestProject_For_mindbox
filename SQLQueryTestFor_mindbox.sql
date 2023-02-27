SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN Categories c
ON p.CategoryID = c.CategoryID;