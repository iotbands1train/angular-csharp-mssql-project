# Frontend

This folder contains the frontend code for our Angular-C#-MSSQL project. The frontend is built using Angular, providing a user-friendly interface for interacting with the application.

## Folder Structure




## Details

- **src/**: Source code for the Angular application.
  - **app/**: Main application folder containing components, services, models, and other Angular files.
    - **components/**: Contains Angular components responsible for rendering different parts of the UI. For example, `user-list/` contains files related to the user list component.
    - **services/**: Contains Angular services for fetching and managing data. For instance, `user.service.ts` might handle HTTP requests to the backend API.
    - **models/**: Contains TypeScript models representing data structures used in the frontend. For example, `user.model.ts` defines the structure of a user object.
    - **app.module.ts**: Main Angular module where you import and declare components, services, and other modules.
    - **app-routing.module.ts**: Angular routing configuration for navigating between different views or components.

- **index.html**: HTML template for the Angular application.

- **styles.css**: Global CSS styles applied to the entire application.

## Usage

To work on the frontend code:

1. Open the frontend folder in your preferred IDE or text editor.
2. Make necessary changes to components, services, models, or other Angular files.
3. Run `npm install` to install dependencies if it's your first time working on the project.
4. Run `ng serve` to start the Angular development server.
5. Access the application through the provided URL (usually `http://localhost:4200`) and test your changes in the browser.

## Dependencies

- Angular
- Angular Material (or any other UI framework used in the frontend)

## Contributing

Contributions to the frontend codebase are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

