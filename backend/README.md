# Backend

This folder contains the backend code for our Angular-C#-MSSQL project. The backend is built using ASP.NET Core, providing RESTful APIs to interact with the database and serve data to the frontend.

## Folder Structure


## Details

- **Controllers/**: Contains ASP.NET Core MVC controllers responsible for handling HTTP requests and returning appropriate responses. For example, `DataController.cs` handles requests related to data manipulation.

- **Models/**: Contains model classes that represent data entities used in the application. For instance, `User.cs` defines the structure of a user entity with properties like `Id`, `Name`, `Email`, etc.

- **Services/**: Contains service classes responsible for implementing business logic and interacting with data sources. For example, `DataService.cs` might contain methods for fetching, creating, updating, and deleting data entities.

- **appsettings.json**: Configuration file for the ASP.NET Core application, containing settings such as connection strings, logging configurations, and other application-specific settings.

- **Startup.cs**: Entry point for configuring the ASP.NET Core application. This file includes methods for configuring services and middleware in the application pipeline.

## Usage

To work on the backend code:

1. Open the backend folder in your preferred IDE or text editor.
2. Make necessary changes to controllers, models, services, or configuration files.
3. Build and run the ASP.NET Core application to test your changes.
4. Ensure that the backend APIs are functioning correctly and returning expected responses.

## Dependencies

- ASP.NET Core
- Entity Framework Core
- MSSQL Server (for database interactions)

## Contributing

Contributions to the backend codebase are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

