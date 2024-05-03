
# CarPortal

**CarPortal** is a web application built with **.NET** that serves as a comprehensive car marketplace. It allows users to list, browse, and manage car listings, featuring a secure and modern web experience. The project leverages **Entity Framework** for database interactions, **Identity UI** for user authentication, **InMemory** for temporary data storage, **MessagePack** for efficient data serialization, and **Razor Language** for dynamic page rendering.

## Features

- **User Authentication**: Secure user registration, login, and role management using **Identity UI**.
- **Car Listings Management**: Allows users to create, view, edit, and delete car listings.
- **Data Persistence**: Powered by **Entity Framework** for handling data operations and migrations.
- **In-Memory Database**: Uses **InMemory** storage for lightweight, quick data access (ideal for testing and development).
- **Efficient Data Serialization**: Utilizes **MessagePack** for high-speed serialization and deserialization of data.
- **Dynamic Web Pages**: Built with **Razor Language**, allowing smooth rendering of interactive, server-side content.

## Tech Stack

- **.NET**: Framework for building robust and scalable web applications.
- **Entity Framework**: Object-relational mapper (ORM) for working with databases.
- **Identity UI**: Provides pre-built authentication and authorization components.
- **InMemory Database**: Used for rapid development and testing without a permanent data store.
- **MessagePack**: Binary serialization library that ensures fast data transfer.
- **Razor Pages**: Allows for server-side generation of HTML with embedded C# code.

## Prerequisites

- **.NET SDK** (version compatible with your project, e.g., .NET 5 or .NET 6)
- **SQL Server** (optional if migrating from InMemory database to a SQL-based database for production)
- **Visual Studio** or **Visual Studio Code** for development

## Getting Started

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/CarPortal.git
   cd CarPortal
   ```

2. **Set Up the Project**:
   Open the project in Visual Studio or your preferred IDE.

3. **Install Dependencies**:
   Restore the NuGet packages by building the solution.

4. **Configure InMemory Database** (for development/testing):
   By default, the application is set up with an **InMemory** database. To switch to a SQL Server database, configure it in the `appsettings.json` file and update `Startup.cs`.

5. **Run Migrations**:
   If using **Entity Framework** with SQL Server:
   ```bash
   dotnet ef database update
   ```

6. **Run the Application**:
   ```bash
   dotnet run
   ```

7. **Access the Application**:
   Open your browser and navigate to `http://localhost:5000` (or the specified port in your configuration).

## Usage

- **Sign Up** or **Login** to create an account.
- **Browse Listings** to view all available cars.
- **Add a Listing** to post your car for sale.
- **Edit or Delete Listings** as required.

## Project Structure

- **Models**: Contains the data models, including car listings and user profiles.
- **Controllers**: Manages HTTP requests, routes, and data processing.
- **Views**: Built using Razor for rendering HTML with embedded C#.
- **Data**: Contains database configurations, migrations, and seed data.
- **Services**: Implements business logic and utility functions.

## Key Libraries

- **Microsoft.EntityFrameworkCore.InMemory**: For in-memory database operations.
- **Microsoft.AspNetCore.Identity.UI**: Handles user authentication and authorization.
- **MessagePack**: Provides efficient serialization for data transfers.
- **Microsoft.AspNetCore.Razor**: Used for server-side rendering of views.

## Contributing

1. **Fork the Repository**
2. **Create a Branch** for your feature or bug fix.
3. **Commit your Changes** with clear messages.
4. **Open a Pull Request** and provide a description of your changes.

## License

This project is licensed under the MIT License.

---

Feel free to reach out with any questions or suggestions to help improve **CarPortal**!
