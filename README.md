This is a simple Web API for managing a Weapon Shop. It allows users to perform CRUD (Create, Read, Update, Delete) operations on weapons, orders, customers, and manufacturers. It also supports querying and managing the relationship between different entities such as customers and their orders.
Table of Contents

    Technology Stack
    Features
    Installation
    Usage
    API Endpoints
    License

Technology Stack

    Backend Framework: ASP.NET Core 6
    Database: SQLite
    ORM: Entity Framework Core
    API: RESTful Web API

Features

    Weapons: Add, update, delete, and view weapons.
    Customers: Add, update, delete, and view customers.
    Orders: Create, update, delete, and view orders placed by customers.
    Many-to-Many Relationship: Manage orders containing multiple weapons.
    Manufacturers and Categories: View and manage weapon manufacturers and categories.

Installation

    Clone the repository:

git clone https://github.com/yourusername/weaponshop-api.git
cd weaponshop-api

    Install dependencies:

    Make sure you have .NET SDK 6 or higher installed. You can download it from here.

    Install required NuGet packages:

dotnet restore

    Create and apply migrations to set up the database:

dotnet ef migrations add InitialCreate
dotnet ef database update

This will create a WeaponShop.db SQLite database file in your project directory.
Usage

    Run the Web API:

dotnet run

This will start the API on https://localhost:5001 or http://localhost:5000 (depending on your configuration).

    Testing the API:

You can use Postman or any HTTP client to interact with the API endpoints. The API follows RESTful conventions, allowing you to perform standard HTTP methods (GET, POST, PUT, DELETE) on resources like weapons, orders, and customers.
API Endpoints
Weapons

    GET /api/weapons: Retrieve all weapons
    GET /api/weapons/{id}: Retrieve a specific weapon by ID
    POST /api/weapons: Create a new weapon
    PUT /api/weapons/{id}: Update an existing weapon by ID
    DELETE /api/weapons/{id}: Delete a weapon by ID

Customers

    GET /api/customers: Retrieve all customers
    GET /api/customers/{id}: Retrieve a specific customer by ID
    POST /api/customers: Create a new customer
    PUT /api/customers/{id}: Update an existing customer by ID
    DELETE /api/customers/{id}: Delete a customer by ID

Orders

    GET /api/orders: Retrieve all orders
    GET /api/orders/{id}: Retrieve a specific order by ID
    POST /api/orders: Create a new order
    PUT /api/orders/{id}: Update an existing order by ID
    DELETE /api/orders/{id}: Delete an order by ID

Ordered Weapons (Join Table)

    GET /api/orderedweapons: Retrieve all ordered weapons
    POST /api/orderedweapons: Add an ordered weapon to an order

License

This project is licensed under the MIT License - see the LICENSE file for details.
