create database restaurant;

use restaurant;

create table menu(category varchar(20), item varchar(20), price float);

drop table menu;

insert into menu values('beverage','Soda',1.9);
insert into menu values('beverage','Tea',11.0);
insert into menu values ('beverage','Coffee',1.25);
insert into menu values('beverage','Mineral Water',2.95);
insert into menu values('beverage','Juice',2.5);
insert into menu values('beverage','Milk',1.5);
-----------------------------------------------------------
insert into menu values('appetizer','Buffalo Wings',5.95);
insert into menu values('appetizer','Buffalo Fingers',6.95);
insert into menu values('appetizer','Potato Skins',8.95);
insert into menu values('appetizer','Nacho',8.95);
insert into menu values('appetizer','Mushroom Caps',10.95);
insert into menu values('appetizer','Shrimp Cocktail',12.95);
insert into menu values('appetizer','Chips and Salsa',6.95);
-------------------------------------------------------------
insert into menu values('Main Course','Chicken Alfredo',13.95);
insert into menu values('Main Course','Chicken Picatta',13.95);
insert into menu values('Main Course','Turkey Club',11.95);
insert into menu values('Main Course','Lobster Pie',19.95);
insert into menu values('Main Course','Prime Rib',20.95);
insert into menu values('Main Course','Shrimp Scampi',18.95);
insert into menu values('Main Course','Turkey Dinner',13.95);
insert into menu values('Main Course','Stuffed Chicken',14.95);
insert into menu values('Main Course','Seafood Alfredo',15.95);
--------------------------------------------------------------
insert into menu values('Desert','Apple Pie',5.95);
insert into menu values('Desert','Sundae',3.95);
insert into menu values('Desert','Carrot Cake',5.95);
insert into menu values('Desert','Mud Pie',3.95);
insert into menu values('Desert','Apple Crisp',3.95);

select * from menu;
use restaurant;
create table cust_transact(tno int, cust_name varchar(20), items varchar(20),item_price float,date_entry date);
drop table cust_transact;
use restaurant;
select * from cust_transact;

select distinct tno from cust_transact;