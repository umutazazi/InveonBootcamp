## Controllers

### UserController

The `UserController` handles user-related operations such as creating, reading, updating, and deleting users. It also manages user authentication and registration.

- **Read**: Retrieves a list of all users. Only accessible by users with the "Admin" role.
- **Create**: Creates a new user. Only accessible by users with the "Admin" role.
- **Update**: Updates an existing user. Only accessible by users with the "Admin" role.
- **Delete**: Deletes a user. Only accessible by users with the "Admin" role.
- **Login**: Authenticates a user using their email and password.
- **Logout**: Logs out the authenticated user.
- **Register**: Registers a new user.

### RoleController

The `RoleController` handles role-related operations such as creating, reading, updating, and deleting roles.

- **Read**: Retrieves a list of all roles. Only accessible by users with the "Admin" role.
- **Create**: Creates a new role. Only accessible by users with the "Admin" role.
- **Update**: Updates an existing role. Only accessible by users with the "Admin" role.
- **Delete**: Deletes a role. Only accessible by users with the "Admin" role.

### BookController

The `BookController` handles book-related operations such as creating, reading, updating, and deleting books.

- **Read**: Retrieves a list of all books.
- **Create**: Creates a new book.
- **Update**: Updates an existing book.
- **Delete**: Deletes a book.

## Authentication

The project uses cookie-based authentication, configured in the `Program.cs` file. This allows users to be authenticated using cookies, which are stored on the client side and sent with each request to the server.

## Unit of Work

The project follows the Unit of Work pattern for data access. This pattern ensures that all database operations are performed in a single transaction, providing a consistent and reliable way to manage data.

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Restore the NuGet packages.
4. Build the solution.
5. Run the application.

