# Library Management System
#### Video Demo: <https://youtu.be/Wg4KgCH23rc>
#### Description:

The Library Management System is a Windows desktop application that helps library staff manage books, students, employees, departments, and borrowing. It is written in C# on .NET Framework 4.8 with Windows Forms and uses a SQL Server database. Staff can add a book by scanning its barcode with a webcam, and the application fills in the book's details from the Open Library API.

I built it as my final project for **CS50: Harvard's Introduction to Computer Science**. The goal was to practice object-oriented design, relational databases, input validation, and connecting software to hardware in one complete application.

[Project overview (Google Drive)](https://drive.google.com/file/d/1jji5tq1SoAHSm_sAPMYodKx2C0OtaMK7/view?usp=sharing)

---

## Features

* **Employee accounts:** Sign up and log in. Passwords are stored as salted PBKDF2 hashes.
* **Permissions:** Each employee can be given access to any of the Home, Students, Books, Statistics, and Profile sections.
* **Barcode scanning:** A webcam reads EAN-13 ISBN barcodes through AForge.NET and ZXing.Net, and book details are fetched from the Open Library API.
* **Records management:** Manage books and their physical copies, students, employees, and departments.
* **Borrowing:** Record a borrow with its return date, track which copies are available, and see borrows that are late. Deleting a borrow record marks the copy as available again.
* **Student status and cards:** Mark students as in the library, out of the library, or blocked. Student and employee profiles show a QR code of their card number.
* **Staff information:** Employees can see their shift, working days, and tasks on their home screen.
* **Statistics and logs:** A dashboard shows usage counts and lists the login, sign-up, borrow, change, and error logs.

---

## Technologies

* C#, .NET Framework 4.8, Windows Forms
* Microsoft SQL Server, ADO.NET
* [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms) for the interface
* [AForge.NET](https://www.nuget.org/packages/AForge.Video.DirectShow) for camera access
* [ZXing.Net](https://www.nuget.org/packages/ZXing.Net) for reading barcodes and generating barcodes and QR codes
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) for reading API responses
* [Open Library Books API](https://openlibrary.org/dev/docs/api/books) for book data

---

## Design Choices

### Three layers
The solution is split into presentation, business, and data projects. Forms talk to the business layer, and only the business layer calls the data layer. The presentation project has no reference to the data project, so SQL stays out of the forms.

### ADO.NET instead of Entity Framework
An ORM would have generated the SQL for me. I chose ADO.NET and wrote the queries by hand to practice the SQL I learned in CS50 and to control exactly what runs against the database. User input is passed through SQL parameters.

### Webcam instead of a dedicated scanner
Typing an ISBN and all of a book's details is slow, and not everyone has a barcode scanner. Using AForge and ZXing means any ordinary webcam can do the job.

---

## Project Structure

The solution is `LibrarySystem.sln`. Some folder names contain spelling mistakes (`Froms`, `Menues`, `BussinesLayer`). The paths below match the actual names.

### PresentationLayer: user interface
* `Program.cs`: Application entry point. Shows the login form, then the main menu.
* `AppSettings.cs`: Shared colors, fonts, and table styling.
* `Fonts/`: The Poppins font files.
* `Froms/Login/`: `StartUp.cs` (login) and `SignupForm.cs` (employee registration).
* `Froms/EMainMenuForm.cs`: The main window. It enables sections according to the employee's permissions.
* `Froms/Menues/`: The main sections: `HomeForm.cs`, `StudentsForm.cs`, `BooksForm.cs`, `StaticsForm.cs` (statistics and logs), and `ProfileForm.cs`.
* `Froms/AddUpdateForms/BooksAndBorrows/`: Adding books and copies (`AddBookForm.cs`, `AddNewBook.cs`, `ViewCurrentBooks.cs`), managing borrows (`AddBorrowForm.cs`, `UpdateBorrowForm.cs`), and scanning barcodes (`ReadBarcodeForm.cs`).
* `Froms/AddUpdateForms/Departments/`, `Employees/`, `Students/`, `Tasks/`: Dialogs for adding and editing those records.
* `Froms/FiltersForms/`: Search filters for books, borrows, and students. `EmployeeFilter.cs` is an unfinished placeholder.
* `Froms/StudentPage/StudateMainForm.cs`: An empty placeholder for a future student area.

### BussinesLayer: logic and validation
* `Security.cs`: Password hashing and verification, permission flags, and card number generation.
* `GlobalVariables.cs`: The logged-in employee and their session data.
* `ObjectClasses/`: Business classes that load and save records through the data layer: `Books.cs`, `Borrows.cs`, `Copys.cs`, `Departments.cs`, `Employees.cs`, `Logs.cs`, `Students.cs`, and `Tasks.cs`.
* `Validators/`: Input checks that the forms use, such as text lengths and email and ISBN formats.
* `Services/CodeReadWrite.cs`: Barcode and QR code reading and writing, and Open Library lookups.

### DataLayer: database access
* `Settings.cs`: The SQL Server connection string.
* `Objects.cs`: Plain classes that carry data between the layers.
* `*DataAccess.cs`: One class per area of the database, containing its SQL queries.

### Other folders
* `ExampleImages/`: Sample department, employee, and student photos.
* `otherfiles/`: [draw.io](https://www.drawio.com/) diagrams of the system and the database.

---

## Getting Started

### Prerequisites
* Windows 10 or 11
* Visual Studio 2022 with the **.NET desktop development** workload
* SQL Server (Express or Developer edition) and SQL Server Management Studio
* A webcam, for barcode scanning
* An internet connection, for restoring NuGet packages and looking up books

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/I3mk132/Library_System.git
   ```
2. Open `LibrarySystem.sln` in Visual Studio.
3. Restore the NuGet packages: right-click the solution and choose **Restore NuGet Packages**.
4. In SQL Server Management Studio, restore `Database/LibraryDB.bak` as a database named `LibraryDB`.
5. In `DataLayer/Settings.cs`, change `connectionString` to match your SQL Server login:
   ```csharp
   public static string connectionString = @"Server=.;Database=LibraryDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;";
   ```
6. Set `PresentationLayer` as the startup project and press **F5**.
7. Choose **Sign up** to create an employee account, then log in.

Guna.UI2 is a commercial library. According to its license, editing forms in the Visual Studio designer requires a Guna activation code or its 14-day trial.

---

## Known Limitations

* Only employees can log in. There is no student login or student area yet.
* Permissions are only enforced in the interface, and the sign-up form gives new employees access to every section.
* The Add Task dialog does not save new tasks yet.
* Photos must be chosen from inside the `ExampleImages` folder, and the application must run from its build folder so it can find them.
* Passwords cannot be reset yet.
* The connection string is stored in the source code, so this project is suitable for local use only.

---

## License

This project is available under the MIT License. Third-party libraries, including Guna.UI2, are covered by their own licenses.
