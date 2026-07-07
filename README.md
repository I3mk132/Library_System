# Library Management System
#### Video Demo: <https://www.youtube.com/watch?v=0r-tLO0CeWI>
#### Description:

The **Library Management System** is a robust, full-stack desktop application developed using C# and the .NET Framework, designed to modernize and streamline the daily operations of institutional or academic libraries. Built upon a scalable **3-Tier Architecture** (Presentation, Business Logic, and Data Access layers) with a SQL Server backend database, this application bridges traditional database management with modern interactive features, such as real-time optical barcode scanning via laptop webcam and external ISBN API integration.

This project was conceived and developed as a comprehensive Final Project for **CS50: Harvard's Introduction to Computer Science**. It demonstrates advanced concepts in Object-Oriented Programming (OOP), secure relational database design, algorithmic validation, graphical user interface (GUI) design, and hardware-software integration.

---

## 🌟 Key Features

* **Secure Authentication & Authorization:** Features a robust login and registration system utilizing secure password hashing techniques. It implements **Role-Based Access Control (RBAC)** to differentiate permissions between institutional employees (librarians/admins) and students.
* **Real-time Barcode Scanning:** Integrates laptop/PC camera hardware using **AForge.Video** and **ZXing.Net** to optically capture and decode book barcodes. When a barcode is scanned, the system fetches book metadata directly from an external ISBN API, drastically speeding up data entry and checkout processes.
* **Comprehensive CRUD Operations:** Full management capabilities for Books, Copies, Student Profiles, Employee Records, Borrowing Tasks, and Library Departments.
* **Borrowing & Return Workflow:** A structured lifecycle tracking system that manages borrow requests, due dates, return confirmations, and real-time availability of physical book copies.
* **Employee Task & Shift Management:** Admin tools to assign tasks, organize departmental shifts, and manage workplace seat/role allocation for library staff.
* **Automated System Logging:** A dedicated audit logging engine that records critical user activities (logins, sign-ups, borrow transactions, and administrative errors) for security and traceability.

---

## 🏛️ Architecture & Design Choices

During the development of this application, several architectural and design choices were debated and finalized to ensure maintainability, performance, and clear separation of concerns:

### 1. Three-Tier Architecture vs. Monolithic Structure
Instead of placing database queries and business rules directly inside UI event handlers (a common approach in basic desktop apps), a strict **3-Tier Architecture** was chosen:
* **Presentation Layer (WinForms + Guna.UI2):** Strictly responsible for rendering UI components, capturing user inputs, and displaying data. **Guna.UI2** was chosen over standard native WinForms controls to deliver a modern, clean, and responsive user experience.
* **Business Logic Layer (BLL):** Handles data validation, object mapping, algorithmic processing, and security checks before any request reaches the database or returns to the UI.
* **Data Access Layer (DAL):** Encapsulates all SQL database communication, keeping SQL queries and connection management isolated.

### 2. ADO.NET vs. Entity Framework (ORM)
While ORMs like Entity Framework automate SQL generation, **raw ADO.NET** was intentionally chosen for the Data Access Layer. This design choice allowed applying the core SQL optimization principles taught in CS50 directly. By writing parameterized SQL queries manually, the system achieves maximum execution speed, prevents SQL Injection vulnerabilities, and maintains fine-grained control over transactional integrity and database locking.

### 3. Hardware Integration (AForge & ZXing) vs. Manual Barcode Entry
To elevate the user experience beyond simple manual text entry, **AForge.Video.DirectShow** and **ZXing (Zebra Crossing)** were integrated. This allows librarians to use any standard webcam as an optical barcode scanner, bridging physical library objects with the digital SQL database seamlessly.

---

## 📂 Project Structure & File Explanations

The solution (`LibrarySystem.sln`) is organized into three distinct class libraries and application projects:

### 🖥️ 1. PresentationLayer (User Interface)
This folder contains the Windows Forms application, visual assets, and UI logic:
* `Program.cs`: The main entry point of the executable that initializes the application state and opens the startup form.
* `AppSettings.cs`: Manages local application configuration, visual themes, and UI preferences.
* `Forms/Login/StartUp.cs` & `SignupForm.cs`: Handles user authentication, registration workflows, and initial role verification.
* `Forms/EMainMenuForm.cs` & `StudateMainForm.cs`: The core dashboard interfaces tailored specifically for Employees/Admins and Students respectively.
* `Forms/Menues/`: Contains the primary navigation modules:
  * `BooksForm.cs`: Displays catalog listings with sorting and searching.
  * `StudentsForm.cs`: Employee interface for monitoring student accounts.
  * `StaticsForm.cs`: Analytics dashboard displaying usage metrics, active borrows, and inventory statistics.
  * `ProfileForm.cs`: Manages personal user account settings and activity logs.
* `Forms/AddUpdateForms/`: Modular dialog forms for data entry and mutation:
  * `BooksAndBorrows/AddBookForm.cs`, `AddNewBook.cs`, `ViewCurrentBooks.cs`: Handles adding new titles, managing multiple book copies, and viewing stock.
  * `BooksAndBorrows/AddBorrowForm.cs`, `UpdateBorrowForm.cs`: Manages the checkout and return transactions.
  * `BooksAndBorrows/ReadBarcodeForm.cs`: The dedicated camera viewport form that activates the webcam, scans barcodes using ZXing, and queries the external API.
  * `Departments/AddUpdateDepartmentForm.cs`, `Employees/EditEmployeeForm.cs`, `Students/AddStudentForm.cs`, `Tasks/AddTaskForm.cs`: Dedicated administrative forms for CRUD operations on respective entities.
* `Forms/FiltersForms/`: Contains specialized floating dialogs (`BookFilter.cs`, `BorrowFilter.cs`, `EmployeeFilter.cs`, `StudentFilter.cs`) that build complex search queries and multi-parameter filtering for data grids.

### ⚙️ 2. BusinessLayer (Logic & Validation)
This library acts as the brain of the system, validating rules and defining data structures:
* `Security.cs`: Implements cryptographic password hashing and verification algorithms to protect user credentials.
* `GlobalVariables.cs`: Maintains session state, currently logged-in user information, and active permission tokens across forms.
* `ObjectClasses/`: Contains plain C# domain models representing database entities: `Books.cs`, `Borrows.cs`, `Copys.cs`, `Departments.cs`, `Employees.cs`, `Logs.cs`, `Students.cs`, and `Tasks.cs`.
* `Validators/`: Contains dedicated validation logic (`BookValidator.cs`, `BorrowValidator.cs`, `StudentValidator.cs`, etc.) that verifies input constraints (e.g., valid email formats, positive copy numbers, date consistency) before passing data to the DAL.
* `Services/CodeReadWrite.cs`: A specialized service class that manages barcode image generation, decoding algorithms, and external API communication for ISBN lookups.

### 🗄️ 3. DataLayer (Database Interaction)
This library handles all direct communication with the Microsoft SQL Server:
* `Settings.cs`: Centrally stores and provides the SQL Server connection string used across all data access methods.
* `Objects.cs`: Data transfer helpers and mapping utilities that translate raw SQL `DataRow` and `SqlDataReader` outputs into strongly-typed C# objects.
* `*DataAccess.cs` (`BooksDataAccess.cs`, `BorrowsDataAccess.cs`, `EmployeesDataAccess.cs`, etc.): Each class corresponds to a database table and encapsulates parameterized SQL queries (`SELECT`, `INSERT`, `UPDATE`, `DELETE`) using `SqlConnection`, `SqlCommand`, and `SqlDataAdapter`.

---

## 🚀 Getting Started

### Prerequisites
* **Operating System:** Windows 10 or Windows 11.
* **IDE:** Visual Studio 2017, 2019, or 2022 (with *.NET Desktop Development* workload installed).
* **Database:** Microsoft SQL Server (Express, Developer, or Enterprise edition) & SQL Server Management Studio (SSMS).
* **Hardware:** A functional webcam (internal laptop camera or USB webcam) for barcode scanning features.
* **Internet Connection:** Required for fetching book details via external ISBN API.

### Installation & Configuration
1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/](https://github.com/)<YOUR_USERNAME>/<YOUR_REPOSITORY_NAME>.git
