# MSFD Product Management App

## Overview

.NET 9.0 Console Application built for the Microsoft Back-End Development course as part of the Full-Stack Certification track. This console application demonstrates Entity Framework Core concepts including DbContext configuration, Code-First migrations, CRUD operations, and transient error handling using SQL Server LocalDB.

## Technologies Used

• .NET 9.0
• Entity Framework Core 9.0
• SQL Server LocalDB
• C# 12

## Getting Started

1. **Clone the repository**
   ```bash
   git clone <MSFD_ProductManagementApp>
   cd MSFD_ProductManagementApp
   ```

2. **Install EF Core Tools**
   ```bash
   dotnet tool install --global dotnet-ef
   ```

3. **Restore packages**
   ```bash
   dotnet restore
   ```

4. **Start SQL Server LocalDB**
   ```bash
   sqllocaldb start MSSQLLocalDB
   ```

5. **Create and apply migrations**
   ```bash
   dotnet ef migrations add InitialMigration
   dotnet ef database update
   ```

6. **Run the application**
   ```bash
   dotnet run
   ```

## Project Structure

```
MSFD_ProductManagementApp/
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Models/
│   └── Product.cs
│
├── Migrations/
│
├── Program.cs
└── MSFD_ProductManagementApp.csproj
```

## Database Models

### Product

• Id (int) - Primary Key, Auto-increment
• Name (string) - Product name
• Price (decimal) - Product price
• StockQuantity (int) - Available inventory

## Key Features

### 1. Code-First Approach
Define database schema using C# classes and generate the database through migrations.

### 2. CRUD Operations
Demonstrates Create, Read, Update, and Delete operations for Product entities.

### 3. Entity Framework Core Configuration
Uses Entity Framework Core with SQL Server LocalDB provider and retry logic for transient failures.

### 4. Transient Error Handling
Implements retry logic with `EnableRetryOnFailure()` to handle temporary database connection issues.

### 5. SQL Server LocalDB Integration
Uses SQL Server LocalDB for development, providing a lightweight SQL Server experience.

## Usage

The application creates a Product Management database with basic CRUD functionality. After running migrations, you can:

• **Create** new products with name, price, and stock quantity
• **Read** and display all products from the database
• **Update** existing product information
• **Delete** products from the inventory

## Key Concepts Demonstrated

✅ Setting up Entity Framework Core with SQL Server
✅ Creating and configuring DbContext with connection string
✅ Defining entity models with proper constructors
✅ Using Code-First migrations for database schema
✅ Implementing transient error retry logic
✅ Performing CRUD operations through Entity Framework
✅ Managing SQL Server LocalDB instances
✅ Organizing project structure with separation of concerns

## About

.NET 9.0 Console Application built for the Microsoft Back-End Development course as part of the Full-Stack Certification track. This console application demonstrates Entity Framework Core concepts including DbContext configuration, Code-First migrations, CRUD operations, and transient error handling using SQL Server LocalDB.
