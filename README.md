# 👨‍💼 Employee Management CRUD API  

A simple **ASP.NET MVC Web API** that performs all 4 CRUD operations (Create, Read, Update, Delete) for managing employee data.  
The project uses **Entity Framework Core with Migrations** for database handling.  

---

## 🚀 Features
- ➕ Add a new employee  
- 📋 Get list of employees  
- ✏️ Update employee details  
- ❌ Delete an employee  
- Database migration support  

---

## 🛠️ Tech Stack
- ASP.NET MVC  
- C#  
- Entity Framework Core (Code First Migrations)  
- SQL Server  

---

## 📂 Database Schema
**Employee Table:**  
- `Id` (Primary Key)  
- `Name`  
- `Email`  
- `Phone`  
- `Salary`  

---

## 📂 Project Structure
employee-crud-api/
├── Controllers/EmployeeController.cs
├── Models/Employee.cs
├── Data/ApplicationDbContext.cs
├── Migrations/
├── Program.cs
├── Startup.cs
└── appsettings.json

---

📬 API Endpoints

GET /api/employee → Get all employees

GET /api/employee/{id} → Get employee by ID

POST /api/employee → Add new employee

PUT /api/employee/{id} → Update employee

DELETE /api/employee/{id} → Delete employee
