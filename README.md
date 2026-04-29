#  Fuel Station Management Console App

A simple console-based fuel station management system developed in C#.
This project simulates basic operations of a fuel station, including fuel purchasing, fuel selling, and cash management.

## Features

* Fuel purchase system (Benzin, Mazot, LPG)
* Fuel selling system with stock control
* Dynamic price calculation (cost + profit margin)
* Cash balance tracking
* User interaction via keyboard input
* Basic UI feedback (success/error screens)

##  Technologies Used

* C#
* .NET Console Application
* Visual Studio Code

##  How It Works

The application runs in a loop and allows the user to:

* Press **A** → Purchase fuel (increases tank, decreases cash)
* Press **S** → Sell fuel (decreases tank, increases cash)
* Press **Q** → Exit application

The system checks:

* If there is enough cash for purchasing fuel
* If there is enough fuel in the tanks before selling

##  Project Structure

```
ConsoleApp11/
 ├── Program.cs
 └── ConsoleApp11.csproj
```

##  Run the Project

```bash
dotnet run
```

## Future Improvements

* Add transaction history (logging)
* Implement user authentication (admin login)
* Improve UI/UX
* Add database support

##  Author

Developed as part of C# learning journey.
