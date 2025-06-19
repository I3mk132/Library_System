# Library Management System

## Overview
This is a full-stack desktop application built with the .NET Framework, using Windows Forms for the user interface, ADO.NET for database connectivity, and SQL Server as the backend database. The system is designed with a 3-tier architecture to ensure modularity, maintainability, and scalability.

The application manages library operations including book borrowing, user management, employee task scheduling, and inventory control.

---

## Features
- **User Authentication:** Secure login system with password hashing and detailed activity logs (sign-up, login, borrow, errors).
- **Role-Based Access Control:** Different permission levels for employees to restrict or allow access to specific features.
- **CRUD Operations:** Create, read, update, and delete functionality for students, employees, books/copies, borrows, and departments.
- **Barcode Scanning:** Utilizes the laptop’s front camera to scan book barcodes and fetch book information via an ISBN API.
- **Borrowing System:** Manages borrowing tasks for students with clear tracking.
- **Employee Task Management:** Includes scheduling, shift planning, and seat allocation for employees.
- **Optimized Database Queries:** Efficient handling of data operations to improve performance.
- **Clean Codebase:** Developed with maintainability and extensibility in mind.

---

## Technologies Used
- .NET Framework  
- Windows Forms (WinForms)  
- ADO.NET  
- SQL Server  
- External ISBN API for book data  

---

## Architecture
The application follows a **3-tier architecture**:  
- **Presentation Layer:** User interface built with WinForms.  
- **Business Logic Layer:** Handles application logic, validation, and permissions.  
- **Data Access Layer:** Manages database interactions using ADO.NET.

---

## Getting Started

### Prerequisites
- Windows OS  
- Visual Studio (2017 or later recommended)  
- SQL Server (Express or full version)  
- Internet connection (for ISBN API calls)  

### Installation
1. Clone or download the repository.  
2. Open the solution file (`.sln`) in Visual Studio.  
3. Configure the SQL Server connection string in the app settings.  
4. Build the solution.  
5. Run the application.

---

## Usage
- Register and log in with your employee or student account.  
- Use the main dashboard to manage books, users, and borrowing tasks.  
- Scan book barcodes using the laptop’s camera to quickly add or retrieve book details.  
- Schedule employee shifts and manage departments efficiently.

---

## Contributing
Contributions are welcome! Feel free to fork the repository, make improvements, and submit pull requests.

---

## License
This project is open-source and available under the MIT License.
