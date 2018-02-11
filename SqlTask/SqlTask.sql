select distinct Name from buys as b
left join clients as c
on c.CustomerId = b.CustomerId
where ProductName = 'Молоко'
and b.CustomerId not in 
(
  select CustomerId from buys
  where PurchaiseDatetime > DATEADD(MONTH, -1, GETDATE())
  group by CustomerId, ProductName
  having ProductName = 'Сметана'
)