create database shopping_APIDB

use shopping_APIDB

create table products
(
	productid int primary key,
	productName varchar(20),
	productCategory varchar(20),
	productPrice int,
	productIsInStock bit
)

insert into products values(101,'Pepsi','Cold-Drink',80,1)
insert into products values(102,'Fossil','Electronics',80,1)
insert into products values(103,'IPhone','Electronics',80,0)
insert into products values(104,'Nike Air','Sports',80,1)
insert into products values(105,'Adidas Wear','Sports',80,0)

alter table products add productDescription varchar(300);