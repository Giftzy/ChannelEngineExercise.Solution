# ChannelEngineExercise.Solution

## Get Started
Prerequisite: 	
    Visual Studio 2019 
	Clone the project
	build and run test / web / console project.	

## Content
	
	A .NET console application which can execute the business logic listed below. Write the results of the logic below to the console output
	An ASP.NET application, which can execute the business logic listed below. Implement this using a controller which displays an HTML table with the results.
	A unit test testing the expected outcome of the “top 5” functionality based on dummy input.

##	Project Business Logic
	Fetch all orders with status IN_PROGRESS from the ChannelEngine API
	From these orders, compile a list of the top 5 products sold (product name, GTIN and total quantity), order these by the total quantity sold in descending order
	Pick one of the products from these orders and use the API to set the stock of this product to 25.

##	Technologies / Patterns
.Net 5.0
C#
Html, CSS, MVC
Dependency Injection, Async await and Github for version control system.
XUnit Test