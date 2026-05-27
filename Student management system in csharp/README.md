# Student Management System
A desktop application built with C# Windows Forms and MySQL.

## Course
Visual Programming (CS-412)

## Technologies Used
- Language: C#
- UI Framework: Windows Forms (.NET Framework 4.7.2)
- Database: MySQL
- Data Access: ADO.NET
- Version Control: Git (GitHub)

## Features
- Login with role-based access (Admin / Viewer)
- Student CRUD operations
- Teacher CRUD operations
- Course CRUD operations
- Enrollment management
- Soft delete on all records
- Search functionality

## Project Structure
- Models/ - Student, Teacher, Course, Enrollment, User
- Database/ - DatabaseHelper.cs, database.sql
- Forms/ - LoginForm, DashboardForm, StudentForm, TeacherForm, CourseForm, EnrollmentForm

## Database Setup
1. Open MySQL Workbench
2. Run database.sql script
3. Database StudentManagementDB will be created

## Default Login
- Username: admin
- Password: admin123

## How to Run
1. Clone the repository
2. Open StudentManagementSystem.sln in Visual Studio
3. Run database.sql in MySQL
4. Update password in DatabaseHelper.cs
5. Press F5 to run