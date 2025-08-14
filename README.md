# My Web App

## Overview
This is a .NET Core web application designed to demonstrate a simple structure for a web project. It includes a home page, error handling, and basic styling and scripting.

## Project Structure
```
my-web-app
├── src
│   ├── Controllers
│   │   └── HomeController.cs
│   ├── Models
│   │   └── ErrorViewModel.cs
│   ├── Views
│   │   ├── Home
│   │   │   └── Index.cshtml
│   │   └── Shared
│   │       └── _Layout.cshtml
│   ├── wwwroot
│   │   ├── css
│   │   │   └── site.css
│   │   └── js
│   │       └── site.js
│   ├── Program.cs
│   ├── Startup.cs
│   └── appsettings.json
├── my-web-app.csproj
└── README.md
```

## Setup Instructions
1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Restore the project dependencies by running:
   ```
   dotnet restore
   ```
4. Run the application using:
   ```
   dotnet run
   ```
5. Open your web browser and navigate to `http://localhost:5000` to view the application.

## Features
- Home page with basic navigation.
- Error handling with a dedicated error view model.
- Responsive design with custom CSS.
- Client-side interactivity using JavaScript.

## Contributing
Feel free to submit issues or pull requests for improvements or bug fixes.