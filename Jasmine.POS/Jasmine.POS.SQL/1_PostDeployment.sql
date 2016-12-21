/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/* Add Role*/
Insert Into [Role]
values
('Admin'), 
('Manager'), 
('Cashier') 

/* Add User */
Insert Into dbo.[User]
values
('Admin','Aa12345', 'Owner', 'Name', 1, '', '', '' )


/* Add Product Category*/
Insert Into ProductCategory
values
('Coffee'), 
('Main'), 
('Sides'), 
('Cold Drinks')

/*Add Product*/
Insert Into Product
values 
('Latte', 3.50, 1),
('Cappuccino', 3.50, 1),
('Hot Chocolate', 3.50, 1),
('Long Black', 3.50, 1),
('Big Breakfast', 11.50, 2),
('Ceasar Salad', 9.50, 2),
('Chicken Schnitzel', 9.50, 2),
('Bacon and Egg Toast', 10.50, 2),
('Chips', 4.50, 3),
('Colesaw', 3.50, 3),
('Gravy', 3.50, 3),
('Coke', 3.50, 4),
('Pepsi', 3.50, 4),
('Orange Juice', 5.00, 4)

/*Add Discount*/
Insert Into Discount
values
('10 % Discount', 0.1),
('20 % Discount', 0.2),
('50 % Discount (Royal Discount)', 0.5)

/*Add Payment Method*/
Insert Into PaymentMethod
values
('Cash'),
('Master Card'),
('Visa')
