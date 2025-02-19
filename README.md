### 📌 **Project: Layered Architecture with ASP.NET Core & SQL Server**

---

## 🛠️ Overview
This project implements a **Layered Architecture** using **ASP.NET Core** and **SQL Server**. It follows best practices for separation of concerns, maintainability, and scalability.

---

## 🏗️ Architecture
```
LayerArchitecture/
│── LayerArchitecture/          # ASP.NET Core Web API
│── LayerArchitecture.BusinessLayer/              # Business Logic & Services
│── LayerArchitecture.Database/                   # Migrations & Database Context
│── LayerArchitecture.PersistenceLayer/           # Database Access (Entity Framework Core)


```

---

## 🛠️ Tech Stack
- **ASP.NET Core** (Web API)
- **C#**
- **Entity Framework Core** (ORM)
- **SQL Server**
- **Migrations** for Database Management

---

## ⚙️ Installation
### 1️⃣ Clone the repository:
```sh
git clone [https://github.com/PhamTrung1204/SOA_LayerArchitecture.git]
cd LayerArchitecture
```
### 2️⃣ Install required NuGet packages:
```sh
Install-Package Microsoft.EntityFrameworkCore -Version 8.0.13
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.13
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.13
```
### 3️⃣ Set up the database:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```
### 4️⃣ Run the Web API:
```sh
dotnet run --project LayerArchitecture
```

---

## 🛠️ Configuration
Modify `appsettings.json` to update your database connection:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=LAPTOP-170KP0RN\\SQLEXPRESS;Initial Catalog=SOA Layer;Integrated Security=True;Trust Server Certificate=True"
}
```

---

## 🏗️ Features
✔️ **Layered Architecture** (Presentation, Business, Persistence, Database)
✔️ **Entity Framework Core** for ORM
✔️ **SQL Server Database** with Migrations
✔️ **CRUD Operations** for Customers & Orders
✔️ **Swagger UI** for API Documentation

---

## 📌 Usage
- Add **Customers & Orders** via Web API
- Retrieve **Customer Orders**
- Database updates automatically with **migrations**

---

## 🤝 Contribution
Pull requests are welcome! To contribute:
1. **Fork** the repository
2. **Create a new branch** (`feature-branch`)
3. **Commit your changes**
4. **Push and submit a PR**

---

## 📜 License
This project is licensed under the **MIT License**.

---

## 🎯 Contact
📧 **Email:** trungpham.31221024740@st.ueh.edu.vn  
🔗 **GitHub:** [[my-github](https://github.com/PhamTrung1204)]

