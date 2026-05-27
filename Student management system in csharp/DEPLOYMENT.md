# Deployment Guide
Student Management System - Visual Programming CS-412

## System Requirements
- OS: Windows 10 or higher
- Visual Studio 2019 or higher
- .NET Framework 4.7.2
- MySQL Server 8.0 or higher
- MySQL Connector/NET (NuGet Package)

## Step 1 - Install MySQL
1. Download MySQL from https://dev.mysql.com/downloads/
2. Install MySQL Server
3. Remember your root password

## Step 2 - Setup Database
1. Open MySQL Workbench
2. Connect to localhost
3. Open database.sql file from project folder
4. Run the script (Ctrl+Shift+Enter)
5. Database StudentManagementDB will be created

## Step 3 - Configure Connection
1. Open DatabaseHelper.cs in Visual Studio
2. Find this line:
   Server=localhost;Database=StudentManagementDB;Uid=root;Pwd=your_password;
3. Replace your_password with your MySQL root password

## Step 4 - Run Application
1. Open StudentManagementSystem.sln in Visual Studio
2. Build Solution (Ctrl+Shift+B)
3. Press F5 to run

## Default Login Credentials
- Username: admin
- Password: admin123

## Database Migration
- Database script is included: database.sql
- Run this script on any machine to recreate the database
- Sample data is included in the script