# 🚀 Student Management System API

This project is developed as part of a **.Net Developer Technical Assignment** for **Zest India IT Pvt Ltd (Pune)**.

---

# 📌 Assignment Overview

The application is a **Student Management System** built using **ASP.NET Core Web API**.
It provides complete CRUD functionality with **secure endpoints using JWT authentication**, proper **layered architecture**, and **global exception handling**.

---

# ✨ Features

✅ Get all students
✅ Get student by ID
✅ Search student by name
✅ Add new student
✅ Update student
✅ Delete student
✅ JWT Authentication (secure APIs)
✅ Global Exception Handling (Middleware)
✅ Logging using Serilog
✅ Swagger API Documentation
✅ Layered Architecture (Controller → Service → Repository)
✅ Unit Testing (xUnit + Moq)

---

# 🏗️ Architecture

The project follows **Layered Architecture**:

```text
Controller → Service → Repository → Database
```

### 🔹 Controller

Handles HTTP requests and responses.

### 🔹 Service

Contains business logic and validations.

### 🔹 Repository

Handles database operations using Entity Framework Core.

### 🔹 Database

SQL Server stores student data.

---

# 🛠️ Tech Stack

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core
* SQL Server
* JWT Authentication
* Serilog (Logging)
* Swagger (API Testing)
* xUnit & Moq (Unit Testing)

---

# 🗄️ Database Structure

## Student Table

| Field       | Type              |
| ----------- | ----------------- |
| Id          | int (Primary Key) |
| Name        | string            |
| Email       | string            |
| Age         | int               |
| Course      | string            |
| CreatedDate | DateTime          |

---

# 🔐 Authentication (JWT)

### 🔹 Login API

```http
POST /api/Auth/login
```

### 🔹 Sample Credentials

```text
Username: admin
Password: 123
```

### 🔹 Response

```json
{
  "token": "your_jwt_token_here"
}
```

### 🔹 How to Use Token

In Swagger click **Authorize 🔒** and paste:

```text
Bearer your_token_here
```

---

# 📡 API Endpoints

## 🔑 Auth

* `POST /api/Auth/login`

---

## 👨‍🎓 Student

* `GET /api/Student` → Get all students
* `GET /api/Student/{id}` → Get student by ID
* `GET /api/Student/search?name=value` → Search student
* `POST /api/Student` → Add student
* `PUT /api/Student` → Update student
* `DELETE /api/Student/{id}` → Delete student

---

# 📥 Sample Request (POST / PUT)

```json
{
  "name": "Asif",
  "email": "asif@gmail.com",
  "age": 22,
  "course": "BCA"
}
```

---

# ⚙️ Setup Instructions

## 🔹 1. Clone Repository

```bash
git clone <your-repo-link>
```

---

## 🔹 2. Open Project

Open solution in **Visual Studio 2022**.

---

## 🔹 3. Configure Database

Edit `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StudentManagementDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

## 🔹 4. Apply Migrations

Open Package Manager Console:

```powershell
Add-Migration InitialCreate
Update-Database
```

If migration already exists:

```powershell
Update-Database
```

---

## 🔹 5. Run Application

Press **F5** or click Run.

---

## 🔹 6. Open Swagger

```text
https://localhost:<port>/swagger
```

---

# 🧪 Unit Testing

Unit tests are implemented for the **Service layer** using:

* xUnit
* Moq

### Covered Scenarios:

* Get students
* Add student
* Delete student (exception case)

---

# ⚠️ Error Handling

Global exception handling is implemented using custom middleware:

* Returns clean JSON error responses
* Prevents application crashes
* Improves debugging

---

# 📊 Logging

Logging is implemented using **Serilog**:

* Logs stored in:

```text
Logs/log.txt
```

---

# 📘 Swagger Documentation

Swagger is enabled for:

* API testing
* Request/Response visualization
* JWT authentication testing

---

# 🚀 Bonus Features

* Unit Testing (xUnit + Moq)
* Clean layered architecture
* Secure JWT authentication

---

# 🧠 Key Concepts Used

* Dependency Injection
* Repository Pattern
* Middleware
* Authentication & Authorization
* Async Programming

---

# 👨‍💻 Author

**Asif Kotla**
.NET Developer

---

# 🎯 Conclusion

This project demonstrates:

* Clean architecture
* Secure API development
* Real-world backend practices

It is designed to meet all requirements of the **Zest India assignment**.

---
