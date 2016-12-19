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
(1, 'Admin'), 
(2, 'Manager'), 
(3, 'Cashier') 

/* Add User */
Insert Into dbo.[User]
values
(1, 'Admin','Aa12345', 'Owner', 'Name', 1, '', '', '' )


/* Add Product Category*/
Insert Into ProductCategory
values
(1, 'Coffee'), 
(2, 'Main'), 
(3, 'Sides'), 
(4, 'Cold Drinks')

/*Add Product*/
Insert Into Product
values 
(1, 'Latte', 3.50, 1),
(2, 'Cappuccino', 3.50, 1),
(3, 'Hot Chocolate', 3.50, 1),
(4, 'Long Black', 3.50, 1),
(5, 'Big Breakfast', 11.50, 2),
(6, 'Ceasar Salad', 9.50, 2),
(7, 'Chicken Schnitzel', 9.50, 2),
(8, 'Bacon and Egg Toast', 10.50, 2),
(9, 'Chips', 4.50, 3),
(10, 'Colesaw', 3.50, 3),
(11, 'Gravy', 3.50, 3),
(12, 'Coke', 3.50, 4),
(13, 'Pepsi', 3.50, 4),
(14, 'Orange Juice', 5.00, 4)

/*Add Discount*/
Insert Into Discount
values
(1, '10 % Discount', 0.1),
(2, '20 % Discount', 0.2),
(3, '50 % Discount (Royal Discount)', 0.5)

/*Add Payment Method*/
Insert Into PaymentMethod
values
(1, 'Cash'),
(2, 'Master Card'),
(3, 'Visa')
