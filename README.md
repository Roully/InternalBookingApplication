# InternalBookingApp

A web application built with ASP.NET Core MVC that allows users to manage and book internal resources such as rooms, equipment, or spaces.

# Setup Instructions
# Step 1
Before you begin, make sure you have the following installed:

-  [Visual Studio 2022](https://visualstudio.microsoft.com/) (with ASP.NET and web development workload)
-  [.NET 6 SDK or later](https://dotnet.microsoft.com/en-us/download)
-  SQL Server Express or LocalDB (included with Visual Studio)
# Step 2 : Configure the Database Connection
Open appsettings.json and make sure the connection string matches your environment.
If you're using SQL Server Express or a remote server, update the server name and authentication accordingly.

# Step 3 : Apply EF Core Migrations
Open Package Manager Console (Tools → NuGet Package Manager → Package Manager Console) and run: the following bash code : 
Update-Database

This creates the database using the existing EF Core migration.

If migrations folder doesn't exist, you can create one:
Add-Migration InitialCreate
Update-Database

# Step 4: Run the Application
Click Run (F5) or Ctrl+F5 from Visual Studio.

The app should launch in your default browser at:
https://localhost:xxxx/
By default, the app opens to the Dashboard showing today’s and upcoming bookings.

# Step 5: Using the App
 
 # Manage Resources
Go to Add Resource in the navigation
Provide a name, description, location, capacity, and availability

 # Book a Resource
Navigate to Add Booking
Select a resource, provide time slot, purpose, and name

# Dashboard
Go to Dashboard to see today’s and upcoming booking

# Features

- View, add, edit, and delete resources
- Book available resources with time slots
- Dashboard showing upcoming bookings

- # Technologies Used

- ASP.NET Core MVC (.NET 6 or 7)
- Entity Framework Core
- SQL Server (LocalDB)
- Bootstrap 5 (for responsive UI)
- Razor Views
# Project Structure
InternalBookingApp/
│
├── Controllers/
│   ├── ResourceController.cs
│   └── BookingsController.cs
│   └── DashboardController.cs
│
├── Models/
│   ├── Resource.cs
│   └── Booking.cs
│
├── Views/
│   ├── Resource/ (Create, Index, Edit, Delete)
│   ├── Bookings/ (Create, Index, Edit, Delete)
│   └── Dashboard/ (Index)
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── wwwroot/           # Static files (CSS, JS, etc.)
├── appsettings.json   # Configuration file
├── Program.cs         # Entry point
└── README.md








