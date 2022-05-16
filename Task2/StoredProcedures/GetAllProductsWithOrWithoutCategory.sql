create procedure [dbo].[GetAllProductsWithOrWithoutCategory]
as
begin
select
       p.[Name] as Product,
	   c.[Name] as Category
from Category_Product cp inner join Category c on c.Id = cp.CategoryId
                         right join Product p on p.Id = cp.ProductId
end