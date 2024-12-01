# **Fortuna**

Fortuna is a modern application designed to track net worth, expenses, assets, and their monthly changes. Built with a focus on scalability and usability, it incorporates a **Blazor Server** frontend, a robust **ASP.NET Core Web API**, and **Entity Framework Core** for database management.

---

## **Features**
- **Expense Tracking**:
  - Manage different expense types and items.
  - Record and categorize expenses.
- **Asset Management**:
  - Track assets, including their purchase price, current value, and associated countries.
- **Net Worth Calculation**:
  - Calculate and visualize your net worth over time.
- **Data Security**:
  - Uses SQL Server for secure and efficient data storage.
- **Responsive Frontend**:
  - Interactive UI built with Blazor for real-time updates and seamless user experience.
- **Scalable Backend**:
  - RESTful API developed with ASP.NET Core, following clean architecture principles.
- **Validation**:
  - Fluent Validation for input validation and EF Core for database constraints.

---

## **Technologies Used**

### **Frontend**
- [Blazor Server](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
  - Interactive and reusable components.

### **Backend**
- [ASP.NET Core Web API](https://dotnet.microsoft.com/en-us/apps/aspnet/apis)
  - Exposes endpoints for CRUD operations.

### **Database**
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
  - Relational database for secure data storage.
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
  - Database schema and data access management.

### **Validation**
- [FluentValidation](https://fluentvalidation.net/)
  - Ensures business rules and data integrity.

### **Other Tools**
- [Swagger/OpenAPI](https://swagger.io/)
  - API documentation and testing.
- [xUnit](https://xunit.net/)
  - Unit testing framework.

---

## **Project Structure**

The project follows a clean and modular architecture:

```plaintext
Fortuna.sln
│
├── Fortuna.Core          # Domain models and shared utilities
├── Fortuna.Data          # Entity Framework Core DbContext and entity configurations
│   ├── Entities          # Database entities (Expense, Asset, etc.)
│   ├── Configurations    # EF Core configurations
│   ├── DbContexts        # Database context (FortunaDbContext)
│
├── Fortuna.Services      # Business logic and DTOs
│   ├── Models            # DTOs for data transfer
│   ├── Services          # Service classes for business logic
│
├── Fortuna.API           # ASP.NET Core Web API
│   ├── Controllers       # RESTful API endpoints
│   ├── Extensions        # Middleware and dependency injection configurations
│
├── Fortuna.Web.Blazor    # Blazor Server frontend
│   ├── Pages             # Razor pages for UI
│   ├── ViewModels        # ViewModels for frontend logic
│
└── Fortuna.Tests         # Unit and integration tests
