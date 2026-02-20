# E-Okul App

A Windows Forms application built with .NET Framework 4.7.2 that simulates a school management system (E-Okul). It provides interfaces for students and teachers to sign in, log in, and manage academic data.

## Features

- **Student Management**: Register new students and log in to view academic status.
- **Teacher Management**: Register new teachers and log in for management tasks.
- **Grade Tracking**: System for tracking grades in subjects like Math, Physics, Biology, Chemistry, History, and English.
- **Database Integration**: Persists data using SQL Server.

## Project Structure

```text
E-Okul App.sln               # Visual Studio Solution file
WindowsFormsApp1/            # Main project directory
├── Classes/                 # Domain models and logic
│   ├── Grades.cs            # Grade data model
│   ├── Program.cs           # Application entry point
│   ├── ServerDecoder.cs     # Database interaction logic
│   ├── Student.cs           # Student data model
│   └── Teacher.cs           # Teacher data model
├── Forms/                   # UI Forms (Windows Forms)
│   ├── MainMenu.cs          # Initial navigation screen
│   ├── StudentLogin.cs      # Student login interface
│   ├── StudentSignIn.cs     # Student registration interface
│   ├── TeacherLogin.cs      # Teacher login interface
│   └── TeacherSignIn.cs     # Teacher registration interface
├── Properties/              # Project properties and resources
├── App.config               # Application configuration (DB connection strings)
└── E-Okul.csproj            # Project file
```

## Stack

- **Language**: C# 7.3
- **Framework**: .NET Framework 4.7.2 (Windows Forms)
- **Database**: SQL Server (LocalDB / MSSQLLocalDB)
- **IDE**: Visual Studio or JetBrains Rider

## Requirements

- Windows OS
- .NET Framework 4.7.2 SDK/Runtime
- SQL Server or SQL Server Express (LocalDB)

## Setup & Run

1.  **Clone the repository**:
    ```bash
    git clone <repository-url>
    cd E-Okul-App
    ```

2.  **Database Setup**:
    - The application expects a database named `StudentsDB`.
    - It uses `(LocalDb)\MSSQLLocalDB` by default (see `StudentSignIn.cs`) or `localhost` (see `App.config`).
    - **TODO**: Provide a SQL script to initialize the tables (`Students`, `Teachers`, `Grades`).

3.  **Configure Connection String**:
    - Check `WindowsFormsApp1\App.config` and ensure the `StudentsDbConn` connection string matches your local SQL Server instance.
    - Note: Some forms have hardcoded connection strings that might need updating if your setup differs.

4.  **Build and Run**:
    - Open `E-Okul App.sln` in Visual Studio or JetBrains Rider.
    - Restore NuGet packages (if any are added in the future).
    - Build the solution (`Ctrl+Shift+B`).
    - Run the project (`F5`).

## Scripts & Commands

- **Build**: Use MSBuild or your IDE's build command.
- **Tests**: 
  - **TODO**: Unit tests are not yet implemented for this project.

## Environment Variables

- No specific environment variables are currently used. Configuration is managed via `App.config`.
