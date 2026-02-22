
## 🛠️ Tech Stack

| Technology | Version |
|---|---|
| .NET Framework | 4.7.2 |
| C# | 7.3 |
| Entity Framework | 6.x |
| SQL Server | LocalDB / SQL Server |
| UI Framework | Windows Forms |

## ⚙️ Prerequisites

- **Visual Studio 2019+** with *.NET desktop development* workload
- **SQL Server** (LocalDB or full instance)
- **.NET Framework 4.7.2** targeting pack

## 🚀 Getting Started

1. **Clone the repository**# 📝 PersonalNotesDesktopCRUD

A Windows Forms desktop application for managing personal notes with full **CRUD** (Create, Read, Update, Delete) functionality, built with **.NET Framework 4.7.2** and **Entity Framework 6**.

## 📸 Features

- ✅ Add new notes (title + content)
- ✅ View all saved notes
- ✅ Delete selected notes
- ✅ Persistent storage using Entity Framework 6 (SQL Server)
- ✅ Clean layered architecture with separation of concerns

## 🏗️ Architecture

The project follows a **layered architecture** with clearly separated responsibilities:

## 🛠️ Tech Stack

| Technology | Version |
|---|---|
| .NET Framework | 4.7.2 |
| C# | 7.3 |
| Entity Framework | 6.x |
| SQL Server | LocalDB / SQL Server |
| UI Framework | Windows Forms |

## ⚙️ Prerequisites

- **Visual Studio 2019+** with *.NET desktop development* workload
- **SQL Server** (LocalDB or full instance)
- **.NET Framework 4.7.2** targeting pack

## 🚀 Getting Started

1. **Clone the repository**
2. **Open the solution** in Visual Studio
3. **Configure the connection string** in `App.config`
4. **Run EF Migrations** (Package Manager Console)
5. **Build and run** the project (`F5`)

## 📄 Data Model

| Property | Type | Constraints |
|---|---|---|
| `Id` | `int` | Primary Key |
| `Title` | `string` | Required, Max 200 chars |
| `Content` | `string` | Required |
| `CreatedAt` | `DateTime` | Required, auto-set on creation |

## 📜 License

This project is open source and available under the [MIT License](LICENSE).
