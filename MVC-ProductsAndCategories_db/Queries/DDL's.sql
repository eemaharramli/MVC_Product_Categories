use Products_Categories;

select * from Products;

select * from Categories;

insert into Categories(Name) values('Laptop'),
									('PC'),
									('Mobile Phone');

insert into Products(Name, Price, CategoryID)
values
('Macbook Pro', 3000, 1),
('IMac', 2000, 2),
('Iphone', 1000, 3);

insert into Categories(Name)
values
('headphone');

insert into Products(Name, Price, CategoryID)
values
('Airpods', 200, 4);